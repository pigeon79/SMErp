using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class DM_INVOPRT : DbObjectModel<DM_INVOPRT, int>
    {
        public DM_INVOPRT()
        {
            INVTRNCDE = "";
            INVTDESC = "";
            ONISSUE = false;
            ONREV = false;
            ONADJUST = false;
            ONSHOPA = false;
            ONORDERA = false;
            ONSALEQTY = false;
            ISORDERNO = false;
            ISPONO = false;
            ISSFCNO = false;
            SUBJECT = "";
            ISVOUCHER = false;
            ISHMERP = false;
            OPERATOR = "";
            OPERDATE = DateTime.Now;
        }
        [Length(2)]
        public string INVTRNCDE { get; set; }
        [Length(15)]
        public string INVTDESC { get; set; }
        public bool ONISSUE { get; set; }
        public bool ONREV { get; set; }
        public bool ONADJUST { get; set; }
        public bool ONSHOPA { get; set; }
        public bool ONORDERA { get; set; }
        public bool ONSALEQTY { get; set; }
        public bool ISORDERNO { get; set; }
        public bool ISPONO { get; set; }
        public bool ISSFCNO { get; set; }
        [AllowNull]
        [Length(20)]
        public string SUBJECT { get; set; }
        public bool ISVOUCHER { get; set; }
        public bool ISHMERP { get; set; }
        [Length(10)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
    }
}
