﻿using System;
using G.Core;
using G.Data.Builder;
using G.Data.Builder.Clause;
using G.Data.Definition;
using G.Data.Model.Composer;
using G.Data.Model.Handler;
using G.Data.Model.Member;
using G.Data.SqlEntry;

namespace G.Data.Model.Saver
{
    class RelationModelSaver : DbModelSaver
    {
        public RelationModelSaver(ObjectInfo info, QueryComposer composer, DataProvider provider, IDbObjectHandler handler)
            : base(info, composer, provider, handler)
        {
        }

        private static void UsingSavedObjectList(Action callback)
        {
            if (Scope<SavedObjectList>.Current == null)
            {
                using (new Scope<SavedObjectList>(new SavedObjectList()))
                {
                    callback();
                    return;
                }
            }
            callback();
        }

        public override object Insert(IDbObject obj)
        {
            object key = null;
            ProcessRelation(obj, () => key = InnerInsert(obj));
            return key;
        }

        private object InnerInsert(IDbObject obj)
        {
            SaveBelongsTo(obj);
            var key = base.Insert(obj);
            foreach (var t2 in Info.CrossTables.Keys)
            {
                SetManyToManyRelation(t2, key, Scope<object>.Current);
            }
            ProcessChildren(obj);
            return key;
        }

        public override void Update(IDbObject obj)
        {
            ProcessRelation(obj, () => InnerUpdate(obj));
        }

        private void InnerUpdate(IDbObject obj)
        {
            SaveBelongsTo(obj);
            base.Update(obj);
            ProcessChildren(obj);
        }

        private void SetManyToManyRelation(Type t, object key1, object key2)
        {
            if ((Info.CrossTables.ContainsKey(t) && (key1 != null)) && (key2 != null))
            {
                CrossTable table = Info.CrossTables[t];
                var builder = new InsertStatementBuilder(new FromClause(table.Name,""));
                builder.Values.Add(new KeyOpValue(table[0].Column, key1, KvOpertation.None));
                builder.Values.Add(new KeyOpValue(table[1].Column, key2, KvOpertation.None));
                SqlStatement sql = builder.ToSqlStatement(Provider.Dialect, Info.QueryRequiredFields, Info.AllowSqlLog);
                Provider.ExecuteNonQuery(sql);
            }
        }

        private static void ProcessRelation(IDbObject obj, Action saveObj)
        {
            UsingSavedObjectList(
                () =>
                {
                    DbEntry.UsingTransaction(delegate
                    {
                        if (!Scope<SavedObjectList>.Current.Contains(obj))
                        {
                            Scope<SavedObjectList>.Current.Add(obj);
                            saveObj();
                        }
                    });
                });
        }

        private void SaveBelongsTo(IDbObject obj)
        {
            foreach (var f in Info.RelationMembers)
            {
                if (f.Is.BelongsTo)
                {
                    var ho = (ILazyLoading)f.GetValue(obj);
                    if (ho.IsLoaded)
                    {
                        object llo = ho.Read();
                        if (llo != null)
                        {
                            RelationSave(llo);
                        }
                    }
                }
            }
        }
        private static void RelationDelete(object obj) {
            ((DbObjectSmartUpdate)obj).Delete();
        }
        private static void RelationSave(object obj)
        {
            ((DbObjectSmartUpdate)obj).Save();
        }

        private static void SetBelongsToForeignKey(IDbObject obj, object subobj, object foreignKey)
        {
            MemberHandler belongsTo = ModelContext.GetInstance(subobj.GetType()).Info.GetBelongsTo(obj.GetType());
            if (belongsTo != null)
            {
                var to = belongsTo.GetValue(subobj) as IBelongsTo;
                if (to != null)
                {
                    to.ForeignKey = foreignKey;
                }
            }
        }

        private void ProcessChildren(IDbObject obj)
        {
            using (new Scope<object>(Handler.GetKeyValue(obj)))
            {
                foreach (MemberHandler member in Info.RelationMembers)
                {
                    if(member.Is.RelationField)
                    {
                        var ho = (ILazyLoading)member.GetValue(obj);
                        if (ho.IsLoaded)
                        {
                            Util.TryEnumerate(ho.Read(),
                                o => SetBelongsToForeignKey(obj, o, Handler.GetKeyValue(obj)));
                        }
                    }
                }
                foreach (MemberHandler member in Info.RelationMembers)
                {
                    var ho = (ILazyLoading)member.GetValue(obj);
                    if (ho.IsLoaded)
                    {
                        if (member.Is.HasOne)
                        {
                            ProcessHasOne(ho);
                        }
                        else if (member.Is.HasMany)
                        {
                            ProcessHasMany(ho);
                        }
                        else if (member.Is.HasAndBelongsToMany)
                        {
                            ProcessHasAndBelongsToMany(obj, member, ho);
                        }
                    }
                }
            }
        }

        private void ProcessHasAndBelongsToMany(IDbObject obj, MemberHandler f, ILazyLoading ho)
        {
            object obj2 = ho.Read();
            if (obj2 != null)
            {
                Util.TryEnumerate(obj2, RelationSave);
            }
            var relations = (IHasAndBelongsToManyRelations)ho;
            foreach (object obj3 in relations.SavedNewRelations)
            {
                SetManyToManyRelation(f.MemberType.GetGenericArguments()[0], Handler.GetKeyValue(obj), obj3);
            }
            foreach (object obj4 in relations.RemovedRelations)
            {
                RemoveManyToManyRelation(f.MemberType.GetGenericArguments()[0], Handler.GetKeyValue(obj), obj4);
            }
        }

        private static void ProcessHasMany(ILazyLoading ho)
        {
            object relatonMember = ho.Read();
            if (relatonMember != null)
            {
                var many = (IHasMany)ho;
                foreach (object obj in many.RemovedValues)
                {
                    //RelationSave(obj);
                    RelationDelete(obj);//吴鸽军更改移除行删除
                }
                Util.TryEnumerate(relatonMember, RelationSave);
            }
        }

        private static void ProcessHasOne(ILazyLoading ho)
        {
            object obj2 = ho.Read();
            if (obj2 == null)
            {
                var one = (IHasOne)ho;
                if (one.LastValue != null)
                {
                    RelationSave(one.LastValue);
                }
            }
            else
            {
                Util.TryEnumerate(obj2, RelationSave);
            }
        }

        private void RemoveManyToManyRelation(Type t, object key1, object key2)
        {
            if ((Info.CrossTables.ContainsKey(t) && (key1 != null)) && (key2 != null))
            {
                CrossTable table = Info.CrossTables[t];
                var builder = new DeleteStatementBuilder(table.Name);
                var condition = (Condition)(CK.K[table[0].Column] == key1);
                condition &= CK.K[table[1].Column] == key2;
                builder.Where.Conditions = condition;
                var sql = builder.ToSqlStatement(Provider.Dialect, Info.QueryRequiredFields, Info.AllowSqlLog);
                Provider.ExecuteNonQuery(sql);
            }
        }
    }
}
