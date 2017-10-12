using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.CW1
{
		public class CW_DM : DbObjectModel<CW_DM, int>
	{
				[DbColumn("ID")]
		public System.Int32 ID{get;set;}

    	[DbColumn("DM")]
		public System.String DM{get;set;}

    	[DbColumn("NAME")]
		public System.String NAME{get;set;}

    	[DbColumn("DETAILNAME")]
		public System.String DETAILNAME{get;set;}

    	[DbColumn("KMFL")]
		public System.Int32 KMFL{get;set;}

    	[DbColumn("YEFX")]
		public System.String YEFX{get;set;}

    	[DbColumn("PY")]
		public System.String PY{get;set;}

    	[DbColumn("JLDWNAME")]
		public System.String JLDWNAME{get;set;}

    	[DbColumn("IDWB")]
		public System.Int32 IDWB{get;set;}

    	[DbColumn("LEVELNUM")]
		public System.Int32 LEVELNUM{get;set;}

    	[DbColumn("ISDETIAL")]
		public System.Int32 ISDETIAL{get;set;}

    	[DbColumn("FTIMESTAMP")]
		public System.Byte[] FTIMESTAMP{get;set;}

    	[DbColumn("PARENTID")]
		public System.Int32 PARENTID{get;set;}

    	[DbColumn("SORTID")]
		public System.Int32 SORTID{get;set;}

    	[DbColumn("HSYHF")]
		public System.Int32 HSYHF{get;set;}

    	[DbColumn("HSGYSF")]
		public System.Int32 HSGYSF{get;set;}

      }
                                             
}
