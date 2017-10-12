using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Controls;
using G.Interface.BLL;
using G.Controls.GGrid;
using G.Controls.Input;

namespace G.Controls.Base
{
    public class Initialize
    {
        public static void InitDropDown(GDropDown control, string type, ISearch searchLogic,bool isdefault)
        {
            control.Logic = searchLogic;
            if (isdefault)
            {
                DefaultField(control, type);
            }
            foreach (ColumnInfo c in GetListColumns(type))
            {
                control.AddGridColumn(c.ColumnName, c.ColumnCaption, c.ColumnType, c.ColumnWidth);
            }
            control.GridEndInit();
        }
        public static void InitDropDown(GDropDown control, string type, ISearch searchLogic, string vfield, string tfield)
        {
            control.ValueField = vfield;
            control.TextField = tfield;
            control.Logic = searchLogic;
            foreach (ColumnInfo c in GetListColumns(type))
            {
                control.AddGridColumn(c.ColumnName, c.ColumnCaption, c.ColumnType, c.ColumnWidth);
            }
            control.GridEndInit();
        }
        public static void InitDropDown(DropDown control, string type, ISearch searchLogic, string vfield, string tfield)
        {
            if (!vfield.IsNullOrEmpty())
            {
                control.ValueField = vfield;
            }
            if (!tfield.IsNullOrEmpty())
            {
                control.TextField = tfield;
            }
            control.Logic = searchLogic;
            control.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            foreach (ColumnInfo c in GetListColumns(type))
            {
                control.AddGridColumn(c.ColumnName, c.ColumnCaption, c.ColumnType, c.ColumnWidth);
            }
            control.GridEndInit();
        }
        public static void InitDropDown(DropDown control, string type, ISearch searchLogic, string vfield, string tfield,bool istext)
        {
            control.IsText = istext;
            InitDropDown(control, type, searchLogic, vfield, tfield);
        }
        public static void InitDropDown(DropDown control, string type, ISearch searchLogic)
        {
            InitDropDown(control, type, searchLogic, "", "");
        }
        private static List<ColumnInfo> GetListColumns(string type)
        {
            List<ColumnInfo> columns = new List<ColumnInfo>();
            switch (type.ToUpper())
            {
                case "CUSTOMER":
                    columns.Add(new GGrid.ColumnInfo("代码", "CUSTCODE", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("客户", "CUSTNAME", "String", 100));
                    columns.Add(new GGrid.ColumnInfo("业务员", "SALESMANNAME", "String", 100));
                    columns.Add(new GGrid.ColumnInfo("业务助理", "SALESREPNAME", "String", 100));
                    break;
                case "AREA":
                    columns.Add(new GGrid.ColumnInfo("地区代码", "DQDM", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("地区名称", "DQNAME", "String", 80));
                    break;
                case "ITEM":
                    columns.Add(new GGrid.ColumnInfo("物品代码", "ItemCode", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("物品名称", "ItemName", "String", 100));
                    break;
                case "WAREHOUSE":
                    columns.Add(new GGrid.ColumnInfo("仓库代码", "WRHSCODE", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("仓库名称", "WRHSNAME", "String", 80));
                    break;
                case "LOCATION":
                    columns.Add(new GGrid.ColumnInfo("库位代码", "LOCCODE", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("库位名称", "LOCNAME", "String", 80));
                    break;
                case "USER":
                    columns.Add(new GGrid.ColumnInfo("用户代码", "USERDM", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("用户", "USERNAME", "String", 80));
                    break;
                case "COLOR":
                    columns.Add(new GGrid.ColumnInfo("色号代码", "CCODE", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("色号名称", "CNAME", "String", 80));
                    break;
                case "COLORNAME":
                    columns.Add(new GGrid.ColumnInfo("色号代码", "CCODE", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("色号名称", "COLORNAME", "String", 80));
                    break;
                case "MOULD":
                    columns.Add(new GGrid.ColumnInfo("花模代码", "MDCODE", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("花模名称", "MDNAME", "String", 80));
                    break;
                case "SUPPLIER":
                    columns.Add(new GGrid.ColumnInfo("供应商代码", "SUPPCODE", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("供应商名称", "SUPPNAME", "String", 80));
                    break;
                case "ORG":
                    columns.Add(new GGrid.ColumnInfo("部门代码", "ORGDM", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("部门名称", "ORGNAME", "String", 80));
                    break;
                case "PORDER":
                    columns.Add(new GGrid.ColumnInfo("采购订单号", "POID", "String", 80));
                    //columns.Add(new GGrid.ColumnInfo("采购日期", "ORGNAME", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("供应商", "SUPPNAME", "String", 100));
                    break;
                case "SALEORDER":
                    columns.Add(new GGrid.ColumnInfo("销售订单号", "ORDERID", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("客户", "CUSTNAME", "String", 100));
                    break;
                case "ASSISTMS":
                    columns.Add(new GGrid.ColumnInfo("外协领料单号", "ASSISTMSCODE", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("客户", "CUSTNAME", "String", 100));
                    break;
                case "ITEMTYPE":
                    columns.Add(new GGrid.ColumnInfo("ID", "Id", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("物品类型", "ITEMTYPENAME", "String", 100));
                    break;
                case "GX":
                    columns.Add(new GGrid.ColumnInfo("工序代码", "GXDM", "String", 80));
                    columns.Add(new GGrid.ColumnInfo("工序名称", "GXNAME", "String", 100));
                    break;
            }
            return columns;
        }

        private static void DefaultField(GDropDown control, string type)
        {
            string vfield = "", tfield = "";
            bool istext = false;
            switch (type.ToUpper())
            {
                case "CUSTOMER":
                    vfield = "ID";
                    tfield = "CUSTNAME";
                    break;
                case "AREA":
                    vfield = "DQDM";
                    tfield = "DQNAME";
                    break;
                case "ITEM":
                    vfield = "ITEMCODE";
                    tfield = "ITEMNAME";
                    break;
                case "WAREHOUSE":
                    vfield = "WRHSCODE";
                    tfield = "WRHSNAME";
                    break;
                case "LOCATION":
                    vfield = "LOCCODE";
                    tfield = "LOCNAME";
                    break;
                case "USER":
                    vfield = "USERDM";
                    tfield = "USERNAME";
                    break;
                case "COLOR":
                    vfield = "CCODE";
                    tfield = "CNAME";
                    break;
                case "COLORNAME":
                    istext = true;
                    vfield = "COLORNAME";
                    tfield = "COLORNAME";
                    break;
                case "MOULD":
                    vfield = "MDCODE";
                    tfield = "MDNAME";
                    break;
                case "SUPPLIER":
                    vfield = "SUPPCODE";
                    tfield = "SUPPNAME";
                    break;
                case "ORG":
                    vfield = "ORGDM";
                    tfield = "ORGNAME";
                    break;
                case "PORDER":
                    vfield = "POID";
                    tfield = "POID";
                    break;
                case "SALEORDER":
                    vfield = "ORDERID";
                    tfield = "ORDERID";
                    break;
                case "ASSISTMS":
                    vfield = "ASSISTMSCODE";
                    tfield = "ASSISTMSCODE";
                    break;
                case "ITEMTYPE":
                    vfield = "ID";
                    tfield = "ITEMTYPENAME";
                    break;
                case "GX":
                    vfield = "ID";
                    tfield = "GXNAME";
                    break;
            }
            control.IsText = istext;
            control.ValueField = vfield;
            control.TextField = tfield;
        }
    }
}
