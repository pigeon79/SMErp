using G.Controls.Base;
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

namespace G.Erp.BaseData
{
    public partial class ItemLocStorage : G.Controls.Input.BaseSearchForm
    {
        public ItemLocStorage()
        {
            InitializeComponent();
            InitColumn();
            LoadDrop();
        }
        public void SetItemCode(SM_SHOPSUPPLYDTL dtl)
        {
            this.txt_ITEMCODE.SetValue(dtl.ITEMCODE);
            this.txt_ITEMDESC.SetValue(dtl.ITEMNAME);
            this.txt_ATTRIBUTEA.SetValue(dtl.ATTRIBUTEA);
            this.drop_attributeb.SetValue(dtl.ATTRIBUTEB);
            SearchData(dtl.ITEMCODE, dtl.ITEMNAME, "", "", dtl.ATTRIBUTEA, dtl.ATTRIBUTEB, "", true);
        }

        G.BLL.ERP.BaseData.DM_ITEMLogic itemlogic = new BLL.ERP.BaseData.DM_ITEMLogic();
        private void btn_search_Click(object sender, EventArgs e)
        {
            string itemcode = G.Core.GConvert.ToString(this.txt_ITEMCODE.Text);
            string itemname = G.Core.GConvert.ToString(this.txt_ITEMDESC.Text);
            string attributea = G.Core.GConvert.ToString(this.txt_ATTRIBUTEA.Text);
            string attributeb = G.Core.GConvert.ToString(this.drop_attributeb.Value);
            string wrhs = G.Core.GConvert.ToString(this.drop_wrhs.Value);
            string loc = G.Core.GConvert.ToString(this.drop_loc.Value);
            bool iszero = G.Core.GConvert.ToBool(this.check_ozero.Value);
            SearchData(itemcode, itemname, wrhs, loc, attributea, attributeb, "", iszero);
        }
        private void SearchData(string itemcode, string itemname, string wrhs, string loc, string attributea, string attributeb, string attributec, bool iszero)
        {
            DataSet ds = itemlogic.SearLocStorage(itemcode, itemname, wrhs, loc, attributea, attributeb, attributec, iszero);
            gGrid1.DataSource = ds.Tables[0];
        }

        private void gGrid1_DoubleClick(object sender, EventArgs e)
        {
            if (this.gGrid1.DataSource != null)
            {
                if (this.gGrid1.Row > 0)
                {
                    int rs = this.gGrid1.Row;
                    rs -= gGrid1.Rows.Fixed;
                    if (rs >= 0)
                    {
                        if (((DataTable)this.gGrid1.DataSource).Rows.Count > rs)
                        {
                            DataRow dr = ((DataTable)this.gGrid1.DataSource).Rows[rs];
                            OnRowSelected(new DataRowEvent { DataRow = dr });
                        }
                        else
                        {
                            OnRowSelected(new DataRowEvent { DataRow = null });
                        }
                    }
                }
            }
            this.Close();
        }
        private void InitColumn()
        {
            gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80);
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100);
            gGrid1.AddGridColumn("ATTRIBUTEA", "色号", "String", 100);
            gGrid1.AddGridColumn("ATTRIBUTEB", "花模", "String", 80);
            gGrid1.AddGridColumn("ATTRIBUTEC", "尺寸", "Decimal", "#0.0", 80);
            gGrid1.AddGridColumn("WRHSNAME", "仓库", "String", 100);
            gGrid1.AddGridColumn("LOCNAME", "库位", "String", 100);
            gGrid1.AddGridColumn("ONHANDQTY", "在库数量", "Decimal", "#0.00", 100);
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        private void LoadDrop()
        {
            Initialize.InitDropDown(drop_wrhs, "WAREHOUSE", new G.BLL.ERP.BaseData.DM_WAREHOUSELogic(), "WRHSCODE", "WRHSNAME");
            Initialize.InitDropDown(drop_loc, "LOCATION", new G.BLL.ERP.BaseData.DM_LOCATIONLogic(), "LOCCODE", "LOCNAME");
            Initialize.InitDropDown(drop_attributeb, "MOULD", new G.BLL.ERP.BaseData.DM_MOULDLogic(), true);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
