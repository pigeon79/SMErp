using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class SM_PRICEPARA : DbObjectModel<SM_PRICEPARA, int>
    {
        public SM_PRICEPARA()
        {
            TYPECODE = "";
            SWEIGHT = 0;
            EWEIGHT = 0;
            PRICE = 0;
        }
        [AllowNull]
        [Length(4)]
        public string TYPECODE { get; set; }
        public System.Decimal? SWEIGHT { get; set; }
        public System.Decimal? EWEIGHT { get; set; }
        public System.Decimal? PRICE { get; set; }
    }

}
