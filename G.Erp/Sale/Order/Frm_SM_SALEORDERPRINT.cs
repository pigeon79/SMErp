using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Controls.GGrid;
using G.Data;
using G.Controls.Base;
using G.BLL.Base;
using G.Entity.ERP;
using G.Controls.Input;
using G.APP.BaseForm;
using G.BLL.ERP.BaseData;

namespace G.Erp.Sale.Order
{
    public partial class Frm_SM_SALEORDERPRINT : G.APP.BaseForm.BaseEditor
    {
        public Frm_SM_SALEORDERPRINT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "销售订单打印";
            this.listTool = new List<string>() { "退出" };
            this.Logic = new G.BLL.ERP.Sale.SM_SALEORDERLogic();
            InitGrid();
        }

        private void InitGrid()
        {
            gGrid1.AddGridColumn("ORDLNNO", "序号", "Int32", 20, true);
            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, true);
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("COLOR", "色号", "String", 80, true);
            gGrid1.AddGridColumn("TCOLORANAME", "工艺色号A", "String", 60, true);
            gGrid1.AddGridColumn("TCOLORBNAME", "工艺色号B", "String", 60, true);
            gGrid1.AddGridColumn("SIZEA", "规格mm", "Decimal", "#0.0", 60);
            gGrid1.AddGridColumn("MOULDANAME", "花模A", "String", 80, true);
            gGrid1.AddGridColumn("MOULDBNAME", "花模B", "String", 80, true);
            gGrid1.AddGridColumn("MOULDCNAME", "花模C", "String", 80, true);
            gGrid1.AddGridColumn("MOULDDNAME", "花模D", "String", 80, true);
            gGrid1.AddGridColumn("STYLENO", "款号", "String", 80, true);
            gGrid1.AddGridColumn("LNQTY", "数量", "Decimal", 80, true);
            gGrid1.AddGridColumn("NEEDING", "注意事项", "String", 120, true);
            gGrid1.AddGridColumn("BASICPRICE", "基本价格", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("MOULDPRICE", "花模加价", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("TCOLORPRICE", "工艺色号加价", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("OTHERPRICE", "其他加价", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("PLANPRICE", "计划价格", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("LNPRICE", "实际价格", "Decimal", "#0.000", 60, true);
            gGrid1.AddGridColumn("LNAMOUNT", "实际金额", "Decimal", "#0.00", 80, true);
            gGrid1.AddGridColumn("LNDISCOUNT", "折扣", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("SAMPLETAG", "是否出样", "Boolean", 60, true);
            gGrid1.FrozenCell = 3;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        string orderid = "";
        bool printtag = false;
        public void SetPara(DataRow drow,string orderid)
        {
            this.orderid = orderid;
            printtag = G.Core.GConvert.ToBool(drow["PRINTTAG"]);
            this.TXT_ORDERID.SetValue(G.Core.GConvert.ToString(drow["ORDERID"]));
            this.TXT_ORDERDATE.SetValue(G.Core.GConvert.ToString(drow["ORDERDATE"]));
            this.TXT_ORDERTYPE.SetValue(G.Core.GConvert.ToString(drow["ORDERTYPENAME"]));
            this.TXT_CUSTLEV.SetValue(G.Core.GConvert.ToString(drow["CUSTLEV"]));
            this.TXT_CUSTNAME.SetValue(G.Core.GConvert.ToString(drow["CUSTNAME"]));
            this.CHECK_ISYL.SetValue(true);
            this.gGrid1.DataSource = GetGridData();
            this.gGrid1.DataBind(GetGridData().Tables[0]);
        }
        private DataSet GetGridData()
        {
            DataSet ds = new DataSet();
            DbEntry.UsingTransaction(delegate
            {
                string csql = string.Format("select * from SM_SALEORDERDTL_V1 where orderid='{0}' ", orderid);
                ds = DbEntry.Provider.ExecuteDataset(csql);
            });
            return ds;
        }

        private void BTN_SALEORDERPRINT_Click(object sender, EventArgs e)
        {
            try
            {
                bool isprint = G.Core.GConvert.ToBool(this.CHECK_ISYL.Value);
                string condition = string.Format("orderid='{0}'", orderid);
                G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Sale\SALEORDER.frx", new List<string>() { "Master", "Detail" }, "saleorderprint", condition);
                printobj.Print(!isprint);
                if (printtag == false)
                {
                    this.InsertSaleOrderStatus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
        private void InsertSaleOrderStatus()
        {
            DbEntry.UsingTransaction(delegate
            {
                string csql = string.Format("UPDATE SM_SALEORDERSTATUS SET PRINTTAG=1 where ORDERID='{0}' ", orderid);
                DbEntry.Provider.ExecuteNonQuery(csql);
            });
        }
    }
}
