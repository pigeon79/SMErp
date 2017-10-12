using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Controls.Base;
using G.Controls.Input;
using G.Data;
using G.Entity.ERP;

namespace G.Erp.Sale.Pocket
{
    public partial class SM_POCKETEDIT : G.APP.BaseForm.BaseMultipleEditor
    {
        public SM_POCKETEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "装箱单";
            this.listTool = new List<string>() { "装箱单", "合格证", "装箱单2", "合格证2", "|", "新增", "保存", "|", "审核", "|", "退出" };
            this.T = typeof(SM_POCKET);
            this.orderby = "POCKID DESC";
            this.Logic = new G.BLL.ERP.Sale.SM_POCKETLogic();
            this.Edapter = initAdapter();
            InitGrid();
            InitDrop();
        }
        public override Controls.Base.IEditorAdapter initAdapter()
        {
            EditorAdapter<SM_POCKET, SM_POCKETDTL> adapter = new EditorAdapter<SM_POCKET, SM_POCKETDTL>();
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "装箱单号", FieldName = "POCKID", Editor = this.TXT_POCKID });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "装箱人", FieldName = "POCKETER", Editor = this.DROP_POCKETER, ValidType = "notnull" });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "装箱日期", FieldName = "POCKETDATE", Editor = this.DATE_POCKETDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "销售订单号", FieldName = "ORDERID", Editor = this.DROP_ORDERID, IsNotEmpty = true });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单员", FieldName = "OPERATOR", Editor = this.DROP_OPERATOR });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "制单日期", FieldName = "OPERDATE", Editor = this.DATE_OPERDATE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "状态", FieldName = "STATUSNAME", Editor = this.TXT_STATUS });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "条形码", FieldName = "BARCODE", Editor = this.TXT_BARCODE });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "装箱总数量", FieldName = "TOTALQTY", Editor = this.TXT_TOTALQTY });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "备注", FieldName = "REMARK", Editor = this.TXT_REMARK });
            adapter.AddEditorInfo(new EditorInfo() { FieldCaption = "装箱明细", FieldName = "POCKETDTL", Editor = this.gGrid1 });
            return adapter;
        }
        public override void InitGrid()
        {
            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, true);
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("UNIT", "单位", "String", 40, true);
            gGrid1.AddGridColumn("ATTRIBUTEA", "色号", "String", 80, true);
            gGrid1.AddGridColumn("ATTRIBUTEBNAME", "花模", "String", 80, true);
            gGrid1.AddGridColumn("ATTRIBUTEC", "尺寸", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("STYLENO", "款号", "String", 80, true);
            gGrid1.AddGridColumn("ORDQTY", "订单数", "Decimal", "#0", 60, true);
            gGrid1.AddGridColumn("UNFINISHQTY", "可装箱数", "Decimal", "#0", 60, true);
            gGrid1.AddGridColumn("POCKETQTY", "装箱数", "Decimal", "#0", 60);
            gGrid1.AddGridColumn("GIFTQTY", "赠送数", "Decimal", "#0", 60);
            
            gGrid1.FrozenCell = 3;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        public override void InitDrop()
        {
            G.BLL.Sys.ND_UserLogic userlogic = new G.BLL.Sys.ND_UserLogic();
            G.BLL.ERP.Sale.SM_SALEORDERLogic salelogic = new BLL.ERP.Sale.SM_SALEORDERLogic();
            Initialize.InitDropDown(DROP_OPERATOR, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_POCKETER, "USER", userlogic, true);
            Initialize.InitDropDown(DROP_ORDERID, "SALEORDER", salelogic, true);
            DROP_ORDERID.DefaultCondition = CK.K["POCKETTAG"].Eq(0) && CK.K["ORDERTYPE"].Ne("3"); ;
            DROP_ORDERID.IsText = true;
        }

        void dropdown_RowSelected(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                gGrid1.GetCurSelect<SM_POCKETDTL>().ITEMNAME = G.Core.GConvert.ToString(e.DataRow["ItemName"]);
                gGrid1.GetCurSelect<SM_POCKETDTL>().UNIT = G.Core.GConvert.ToString(e.DataRow["INVUNIT"]);
            }
            gGrid1.Refresh();
        }
        public override void AddRow()
        {
            SM_POCKETDTL pocketdtl = gGrid1.AddRow<SM_POCKETDTL>();
        }
        public override void DeleteRow()
        {
            gGrid1.DeleteRow<SM_POCKETDTL>();
        }

        private void gGrid1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Col == 9)
            {
                SM_POCKET pocket = this.editData as SM_POCKET;
                decimal total = 0;
                foreach (SM_POCKETDTL d in pocket.POCKETDTL)
                {
                    total += (decimal)d.POCKETQTY;
                }
                pocket.TOTALQTY = total;
                TXT_TOTALQTY.SetValue(total);
                this.gGrid1.Refresh();
            }
        }

        private void DROP_ORDERID_RowSelect(object sender, Interface.Event.DataRowEvent e)
        {
            if (e.DataRow != null)
            {
                string orderid = G.Core.GConvert.ToString(e.DataRow["ORDERID"]);
                string sql = string.Format("select a.*,a.BOMQTY-ISNULL(b.pocketqty,0) as UNFINISHQTY,C.INVUNIT from SM_BOMTEMP_V1 a left join (select ORDERID,ORDLNNO,ITEMCODE,SUM(POCKETQTY) as pocketqty from SM_POCKETDTL group by ORDERID,ORDLNNO,ITEMCODE) b on a.ORDERID=b.ORDERID and a.ORDLNNO=b.ORDLNNO AND A.ITEMCODE=B.ITEMCODE LEFT JOIN DM_ITEM C ON A.ITEMCODE=C.ITEMCODE where A.TYPEID=1 AND a.ORDERID='{0}' ", orderid);
                DataSet ds = G.Data.DbEntry.Provider.ExecuteDataset(sql);
                if (ds.Tables[0].Rows.Count>0)
                {
                    BindingList<SM_POCKETDTL> L_pocketd = this.gGrid1.DataSource as BindingList<SM_POCKETDTL>;
                    L_pocketd.Clear();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        SM_POCKETDTL pocketdtl = new SM_POCKETDTL();
                        pocketdtl.BOMTEMPID = G.Core.GConvert.ToInt(dr["ID"]);
                        pocketdtl.ORDERID = G.Core.GConvert.ToString(dr["ORDERID"]);
                        pocketdtl.ORDLNNO = G.Core.GConvert.ToInt(dr["ORDLNNO"]);
                        pocketdtl.ITEMCODE = G.Core.GConvert.ToString(dr["ITEMCODE"]);
                        pocketdtl.ITEMNAME = G.Core.GConvert.ToString(dr["ITEMNAME"]);
                        pocketdtl.UNIT = G.Core.GConvert.ToString(dr["INVUNIT"]);
                        pocketdtl.ORDQTY = G.Core.GConvert.ToInt(dr["BOMQTY"]);
                        pocketdtl.ATTRIBUTEA = G.Core.GConvert.ToString(dr["ATTRIBUTEA"]);
                        pocketdtl.ATTRIBUTEB = G.Core.GConvert.ToString(dr["ATTRIBUTEB"]);
                        pocketdtl.ATTRIBUTEBNAME = G.Core.GConvert.ToString(dr["ATTRIBUTEBNAME"]);
                        pocketdtl.ATTRIBUTEC = G.Core.GConvert.ToDecimal(dr["ATTRIBUTEC"]);
                        pocketdtl.STYLENO = G.Core.GConvert.ToString(dr["ATTRIBUTED"]);
                        pocketdtl.UNFINISHQTY = G.Core.GConvert.ToDecimal(dr["UNFINISHQTY"]); ;
                        L_pocketd.Add(pocketdtl);
                    }
                }
            }
            gGrid1.Refresh();
        }
        public override void ToolButtonClick(string name)
        {
            switch (name)
            {
                case "审核":
                    Audit();
                    break;
                case "装箱单":
                    PocketPrint(false);
                    break;
                case "合格证":
                    CertPrint(false);
                    break;
                case "装箱单2":
                    PocketPrint2(false);
                    break;
                case "合格证2":
                    CertPrint2(false);
                    break;
            }
            base.ToolButtonClick(name);
        }
        private void Audit()
        {
            try
            {
                SM_POCKET pocket = this.editData as SM_POCKET;
                new G.BLL.ERP.Sale.SM_POCKETLogic().Audit(G.AppInfo.GGlobal.User, pocket);
                MessageBox.Show("审核完成！");
                this.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void CertPrint(bool isprint) {
            try
            {
                SM_POCKET pocket = this.editData as SM_POCKET;
                string pockid = G.Core.GConvert.ToString(pocket.POCKID);
                string sqlstr = string.Format("EXEC SMProc_GetCertData '{0}'", pockid);
                DataSet ds = DbEntry.Provider.ExecuteDataset(sqlstr);

                G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Sale\CERTIFICATE.frx", new List<string>() { "Master" }, ds);
                printobj.Print(isprint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PocketPrint(bool isprint)
        {
            try
            {
                SM_POCKET pocket = this.editData as SM_POCKET;
                string pockid = G.Core.GConvert.ToString(pocket.POCKID);
                string condition = string.Format("pockid='{0}'", pockid);
                G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Sale\POCKET.frx", new List<string>() { "Master", "Detail" }, "pocketprint", condition);
                printobj.Print(isprint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CertPrint2(bool isprint)
        {
            try
            {
                SM_POCKET pocket = this.editData as SM_POCKET;
                string pockid = G.Core.GConvert.ToString(pocket.POCKID);
                string sqlstr = string.Format("EXEC SMProc_GetCertData '{0}'", pockid);
                DataSet ds = DbEntry.Provider.ExecuteDataset(sqlstr);

                G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Sale\CERTIFICATE2.frx", new List<string>() { "Master" }, ds);
                printobj.Print(isprint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PocketPrint2(bool isprint)
        {
            try
            {
                SM_POCKET pocket = this.editData as SM_POCKET;
                string pockid = G.Core.GConvert.ToString(pocket.POCKID);
                string condition = string.Format("pockid='{0}'", pockid);
                G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Sale\POCKET2.frx", new List<string>() { "Master", "Detail" }, "pocketprint", condition);
                printobj.Print(isprint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}