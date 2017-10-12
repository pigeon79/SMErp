using G.Data;
using G.Entity.ERP;
using G.Interface.CLIENT;
using G.Interface.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G.Erp.Sale
{
    public partial class SaleOrderSearch : G.Controls.Input.BaseSearchForm
    {
        public SaleOrderSearch()
        {
            InitializeComponent();
            InitColumn();
        }

        public DataSet ds = new DataSet();
        public string c = "";
        private void btn_search_Click(object sender, EventArgs e)
        {
            c = "";
            string orderids = G.Core.GConvert.ToString(TXT_ORDERIDS.Text);
            if (orderids != "")
            {
                try
                {
                    string[] name = orderids.Split(',');
                    foreach (string s in name)
                    {
                        string orderid = G.Core.Common.Usually.GetPadingNO("SO", s, 10);
                        c += "'" + orderid + "',";
                    }
                    c = c.Substring(0, c.Length - 1).Replace("'", "''");

                    DbEntry.UsingTransaction(delegate
                    {
                        string csql = string.Format("EXEC Pro_GetData '{0}','{1}'", "getxskpdata", c);
                        ds = DbEntry.Provider.ExecuteDataset(csql);
                    });
                    gGrid1.DataSource = ds.Tables[0];
                    //gGrid1.AllowEditing = true;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        private void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            //if (this.gGrid1.DataSource != null)
            //{
            //    if (this.gGrid1.Row > 0)
            //    {
            //        int rs = this.gGrid1.Row;
            //        rs -= gGrid1.Rows.Fixed;
            //        if (rs >= 0)
            //        {
            //            if (((DataTable)this.gGrid1.DataSource).Rows.Count > rs)
            //            {
            //                DataRow dr = ((DataTable)this.gGrid1.DataSource).Rows[rs];
            //                OnRowSelected(new DataRowEvent { DataRow = dr });
            //            }
            //            else
            //            {
            //                OnRowSelected(new DataRowEvent { DataRow = null });
            //            }
            //        }
            //    }
            //}
            //this.Close();
        }
        private void InitColumn()
        {
            gGrid1.AddGridColumn("ISSELECT", "选择", "Boolean", 40, false);
            gGrid1.AddGridColumn("ORDERID", "销售订单", "String", 80, true);
            gGrid1.AddGridColumn("ORDERDATE", "订单日期", "DateTime", "yyyy-MM-dd", 80, true);
            gGrid1.AddGridColumn("CUSTNAME", "下单客户", "String", 150, true);
            gGrid1.AddGridColumn("INVCUSTNAME", "开票客户", "String", 150, true);

            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, true);
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("JLDW", "单位", "String", 40, true);
            gGrid1.AddGridColumn("ITEMNAME", "色号", "String", 100, true);
            gGrid1.AddGridColumn("TCOLORANAME", "工艺色号", "String", 100, true);
            gGrid1.AddGridColumn("MOULDA", "花模", "String", 100, true);
            gGrid1.AddGridColumn("SIZEA", "尺寸", "Decimal", "#0.0", 60, true);
            gGrid1.AddGridColumn("STYLENO", "款号", "String", 100, true);
            gGrid1.AddGridColumn("QTY", "数量", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("ATPRICE", "含税单价", "Decimal", "#0.00", 60, true);
            gGrid1.AddGridColumn("ATMONEY", "含税金额", "Decimal", "#0.0000", 80, true);
            gGrid1.AddGridColumn("ORDERTYPENAME", "订单类型", "String", 80, true);
            gGrid1.AddGridColumn("JBRLBNAME", "业务员", "String", 60, true);
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }
        private void ItemSearch_Load(object sender, EventArgs e)
        {
            gGrid1.DataSource = null;
        }
    }
}
