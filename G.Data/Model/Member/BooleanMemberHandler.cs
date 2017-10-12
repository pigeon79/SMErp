using System;
using G.Data.Model.Member.Adapter;

namespace G.Data.Model.Member
{
    public class BooleanMemberHandler : MemberHandler
    {
        public BooleanMemberHandler(MemberAdapter fi)
            : base(fi)
        {
        }

        protected override void InnerSetValue(object obj, object value)
        {
            MemberInfo.SetValue(obj, Convert.ToBoolean(value));
        }
    }
}
