using System;
using G.Data.Definition;
using G.Data.Model.Handler;
using System.Collections.Generic;

namespace G.Entity.Test
{
    public class NDARTICLE : DbObjectModel<NDARTICLE, int>
    {
        [DbColumn("ARTICLE")]
        public string ARTICLE { get; set; }

        [BelongsTo, DbColumn("USERID")]
        public NDUSER USER { get; set; }
    }
    //[DbContext("SqlServer")]
    public class NDUSER : DbObjectModel<NDUSER,int>
    {
        [DbColumn("USERDM")]
        public string USERDM { get; set; }

        [DbColumn("USERNAME")]
        public string USERNAME { get; set; }

        [DbColumn("PASSWORD")]
        public string PASSWORD { get; set; }

        [DbColumn("ISMANAGER")]
        public int ISMANAGER { get; set; }

        [HasMany(OrderBy = "Id")]
        public IList<NDARTICLE> NDARTICLES { get; private set; }
    }

    [DbTable("Books")]
    public class Book : DbObjectModel<Book>
    {
        [Length(50)]
        public string Name { get; set; }

        [BelongsTo, DbColumn("Category_Id")]
        public Category Category { get; set; }
    }

    [DbTable("Categories")]
    public class Category : DbObjectModel<Category>
    {
        [Length(50)]
        public string Name { get; set; }

        [HasMany(OrderBy = "Id")]
        public IList<Book> Books { get; private set; }
    }

}
