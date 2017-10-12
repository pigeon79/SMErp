using System;
using System.Text;

namespace Entity1
{
		public class ND_BILLENTRY
		{
			private System.Int32 m_ID = -1;
        	private System.String m_DJLX = "";
        	private System.String m_FIELDNAME = "";
        	private System.String m_FIELDCAPTION = "";
        	private System.String m_FIELDCAPTIONTWO = "";
        	private System.String m_KJBM = "";
        	private System.String m_SOURCETABLE = "";
        	private System.String m_SOURCEKEYNAME = "";
        	private System.String m_SOURCECODE = "";
        	private System.String m_SOURCENAME = "";
        	private System.String m_SOURCECONDITION = "";
        	private System.Int32 m_EDITINDEX = 0;
        	private System.Int32 m_LISTINDEX = 0;
        	private System.String m_ATTACHFIELD = "";
        	private System.Boolean m_ISINUSE = false;
        	private System.Boolean m_ISDESIGNABLE = false;
        	private System.Boolean m_ISVISIBLE_EDIT = false;
        	private System.Boolean m_ISVISIBLE_LIST = false;
        	private System.Boolean m_ISUPDATE = false;
        	private System.Boolean m_ISREADONLY = false;
        	private System.Boolean m_ISAUTOCOPY = false;
        	private System.Boolean m_ISMUST = false;
        	private System.String m_SFPX = "";
        	private System.String m_FIELDTYPE = "";
        	private System.Int32 m_FIELDLEN = 0;
        	private System.Int32 m_POINTLEN = 0;
        	private System.String m_DISPFORMAT = "";
        	private System.String m_EXPRESSION = "";
        	private System.String m_ERRORMESSAGE = "";
        	private System.Boolean m_ISVALID = false;
        	private System.String m_VALIDTYPE = "";
        	private System.String m_DEFAULTVALUE = "";
        	private System.Decimal m_WIDTH = 0;
        	private System.Int32 m_CON_LEFT = 0;
        	private System.Int32 m_CON_TOP = 0;
        	private System.Int32 m_CON_WIDTH = 0;
        	private System.Int32 m_CON_HEIGHT = 0;
        	private System.Boolean m_DJTXT_LABELFX = false;
        	private System.Int32 m_DJTXT_STYLETYPE = 0;
        	private System.Int32 m_DJTXT_DATATYPE = 0;
        	private System.String m_CON_TYPE = "";
        	private System.Int32 m_CON_ALIGNMENT = 0;
        	private System.String m_CON_FORECOLOR = "";
        	private System.String m_CON_BACKCOLOR = "";
        	private System.String m_CON_FONT = "";
        	private System.Int32 m_CON_TABINDEX = 0;
        	private System.String m_CON_CONTAINER = "";
        	private System.Int32 m_ZDXSLX = 0;
        	private System.String m_FCLASS = "";
        	private System.String m_BORDERLINECOLOR = "";
        	private System.Decimal m_BORDERLINEWIDTH = 0;
        	private System.Boolean m_BORDERLINESLANT = false;
        	private System.Boolean m_ALLOWMULTISELECT = false;
        	private System.Boolean m_MULTILINE = false;
        	private System.Boolean m_AUTONEW = false;
        	private System.String m_ATTACHFIELDTWO = "";
        	private System.String m_EXTENDXML = "";
        
			public ND_BILLENTRY(){
	
			}
					public System.Int32 ID
			{
				get { return this.m_ID; }
				set { this.m_ID = value; }
			}

    		public System.String DJLX
			{
				get { return this.m_DJLX; }
				set { this.m_DJLX = value; }
			}

    		public System.String FIELDNAME
			{
				get { return this.m_FIELDNAME; }
				set { this.m_FIELDNAME = value; }
			}

    		public System.String FIELDCAPTION
			{
				get { return this.m_FIELDCAPTION; }
				set { this.m_FIELDCAPTION = value; }
			}

    		public System.String FIELDCAPTIONTWO
			{
				get { return this.m_FIELDCAPTIONTWO; }
				set { this.m_FIELDCAPTIONTWO = value; }
			}

    		public System.String KJBM
			{
				get { return this.m_KJBM; }
				set { this.m_KJBM = value; }
			}

    		public System.String SOURCETABLE
			{
				get { return this.m_SOURCETABLE; }
				set { this.m_SOURCETABLE = value; }
			}

    		public System.String SOURCEKEYNAME
			{
				get { return this.m_SOURCEKEYNAME; }
				set { this.m_SOURCEKEYNAME = value; }
			}

    		public System.String SOURCECODE
			{
				get { return this.m_SOURCECODE; }
				set { this.m_SOURCECODE = value; }
			}

    		public System.String SOURCENAME
			{
				get { return this.m_SOURCENAME; }
				set { this.m_SOURCENAME = value; }
			}

    		public System.String SOURCECONDITION
			{
				get { return this.m_SOURCECONDITION; }
				set { this.m_SOURCECONDITION = value; }
			}

    		public System.Int32 EDITINDEX
			{
				get { return this.m_EDITINDEX; }
				set { this.m_EDITINDEX = value; }
			}

    		public System.Int32 LISTINDEX
			{
				get { return this.m_LISTINDEX; }
				set { this.m_LISTINDEX = value; }
			}

    		public System.String ATTACHFIELD
			{
				get { return this.m_ATTACHFIELD; }
				set { this.m_ATTACHFIELD = value; }
			}

    		public System.Boolean ISINUSE
			{
				get { return this.m_ISINUSE; }
				set { this.m_ISINUSE = value; }
			}

    		public System.Boolean ISDESIGNABLE
			{
				get { return this.m_ISDESIGNABLE; }
				set { this.m_ISDESIGNABLE = value; }
			}

    		public System.Boolean ISVISIBLE_EDIT
			{
				get { return this.m_ISVISIBLE_EDIT; }
				set { this.m_ISVISIBLE_EDIT = value; }
			}

    		public System.Boolean ISVISIBLE_LIST
			{
				get { return this.m_ISVISIBLE_LIST; }
				set { this.m_ISVISIBLE_LIST = value; }
			}

    		public System.Boolean ISUPDATE
			{
				get { return this.m_ISUPDATE; }
				set { this.m_ISUPDATE = value; }
			}

    		public System.Boolean ISREADONLY
			{
				get { return this.m_ISREADONLY; }
				set { this.m_ISREADONLY = value; }
			}

    		public System.Boolean ISAUTOCOPY
			{
				get { return this.m_ISAUTOCOPY; }
				set { this.m_ISAUTOCOPY = value; }
			}

    		public System.Boolean ISMUST
			{
				get { return this.m_ISMUST; }
				set { this.m_ISMUST = value; }
			}

    		public System.String SFPX
			{
				get { return this.m_SFPX; }
				set { this.m_SFPX = value; }
			}

    		public System.String FIELDTYPE
			{
				get { return this.m_FIELDTYPE; }
				set { this.m_FIELDTYPE = value; }
			}

    		public System.Int32 FIELDLEN
			{
				get { return this.m_FIELDLEN; }
				set { this.m_FIELDLEN = value; }
			}

    		public System.Int32 POINTLEN
			{
				get { return this.m_POINTLEN; }
				set { this.m_POINTLEN = value; }
			}

    		public System.String DISPFORMAT
			{
				get { return this.m_DISPFORMAT; }
				set { this.m_DISPFORMAT = value; }
			}

    		public System.String EXPRESSION
			{
				get { return this.m_EXPRESSION; }
				set { this.m_EXPRESSION = value; }
			}

    		public System.String ERRORMESSAGE
			{
				get { return this.m_ERRORMESSAGE; }
				set { this.m_ERRORMESSAGE = value; }
			}

    		public System.Boolean ISVALID
			{
				get { return this.m_ISVALID; }
				set { this.m_ISVALID = value; }
			}

    		public System.String VALIDTYPE
			{
				get { return this.m_VALIDTYPE; }
				set { this.m_VALIDTYPE = value; }
			}

    		public System.String DEFAULTVALUE
			{
				get { return this.m_DEFAULTVALUE; }
				set { this.m_DEFAULTVALUE = value; }
			}

    		public System.Decimal WIDTH
			{
				get { return this.m_WIDTH; }
				set { this.m_WIDTH = value; }
			}

    		public System.Int32 CON_LEFT
			{
				get { return this.m_CON_LEFT; }
				set { this.m_CON_LEFT = value; }
			}

    		public System.Int32 CON_TOP
			{
				get { return this.m_CON_TOP; }
				set { this.m_CON_TOP = value; }
			}

    		public System.Int32 CON_WIDTH
			{
				get { return this.m_CON_WIDTH; }
				set { this.m_CON_WIDTH = value; }
			}

    		public System.Int32 CON_HEIGHT
			{
				get { return this.m_CON_HEIGHT; }
				set { this.m_CON_HEIGHT = value; }
			}

    		public System.Boolean DJTXT_LABELFX
			{
				get { return this.m_DJTXT_LABELFX; }
				set { this.m_DJTXT_LABELFX = value; }
			}

    		public System.Int32 DJTXT_STYLETYPE
			{
				get { return this.m_DJTXT_STYLETYPE; }
				set { this.m_DJTXT_STYLETYPE = value; }
			}

    		public System.Int32 DJTXT_DATATYPE
			{
				get { return this.m_DJTXT_DATATYPE; }
				set { this.m_DJTXT_DATATYPE = value; }
			}

    		public System.String CON_TYPE
			{
				get { return this.m_CON_TYPE; }
				set { this.m_CON_TYPE = value; }
			}

    		public System.Int32 CON_ALIGNMENT
			{
				get { return this.m_CON_ALIGNMENT; }
				set { this.m_CON_ALIGNMENT = value; }
			}

    		public System.String CON_FORECOLOR
			{
				get { return this.m_CON_FORECOLOR; }
				set { this.m_CON_FORECOLOR = value; }
			}

    		public System.String CON_BACKCOLOR
			{
				get { return this.m_CON_BACKCOLOR; }
				set { this.m_CON_BACKCOLOR = value; }
			}

    		public System.String CON_FONT
			{
				get { return this.m_CON_FONT; }
				set { this.m_CON_FONT = value; }
			}

    		public System.Int32 CON_TABINDEX
			{
				get { return this.m_CON_TABINDEX; }
				set { this.m_CON_TABINDEX = value; }
			}

    		public System.String CON_CONTAINER
			{
				get { return this.m_CON_CONTAINER; }
				set { this.m_CON_CONTAINER = value; }
			}

    		public System.Int32 ZDXSLX
			{
				get { return this.m_ZDXSLX; }
				set { this.m_ZDXSLX = value; }
			}

    		public System.String FCLASS
			{
				get { return this.m_FCLASS; }
				set { this.m_FCLASS = value; }
			}

    		public System.String BORDERLINECOLOR
			{
				get { return this.m_BORDERLINECOLOR; }
				set { this.m_BORDERLINECOLOR = value; }
			}

    		public System.Decimal BORDERLINEWIDTH
			{
				get { return this.m_BORDERLINEWIDTH; }
				set { this.m_BORDERLINEWIDTH = value; }
			}

    		public System.Boolean BORDERLINESLANT
			{
				get { return this.m_BORDERLINESLANT; }
				set { this.m_BORDERLINESLANT = value; }
			}

    		public System.Boolean ALLOWMULTISELECT
			{
				get { return this.m_ALLOWMULTISELECT; }
				set { this.m_ALLOWMULTISELECT = value; }
			}

    		public System.Boolean MULTILINE
			{
				get { return this.m_MULTILINE; }
				set { this.m_MULTILINE = value; }
			}

    		public System.Boolean AUTONEW
			{
				get { return this.m_AUTONEW; }
				set { this.m_AUTONEW = value; }
			}

    		public System.String ATTACHFIELDTWO
			{
				get { return this.m_ATTACHFIELDTWO; }
				set { this.m_ATTACHFIELDTWO = value; }
			}

    		public System.String EXTENDXML
			{
				get { return this.m_EXTENDXML; }
				set { this.m_EXTENDXML = value; }
			}

      }
                                             
}
