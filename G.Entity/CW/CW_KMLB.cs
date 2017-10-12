using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.CW
{
    public class CW_KMLB : DbObjectModel<CW_KMLB, int>
	{
    	[DbColumn("KMLBDM")]
		public System.String KMLBDM{get;set;}

    	[DbColumn("KMLBNAME")]
		public System.String KMLBNAME{get;set;}

    	[DbColumn("PY"),AllowNull]
		public System.String PY{get;set;}

    	[DbColumn("FTIMESTAMP")]
		public System.Byte[] FTIMESTAMP{get;set;}

    	[DbColumn("JDFX")]
		public System.String JDFX{get;set;}

      }
                                             
}
