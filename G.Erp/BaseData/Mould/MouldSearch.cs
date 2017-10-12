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
    public partial class MouldSearch : G.Controls.Input.BaseSearchForm
    {
        public MouldSearch()
        {
            InitializeComponent();
            InitColumn();
        }

        G.BLL.ERP.BaseData.DM_MOULDLogic mouldlogic = new BLL.ERP.BaseData.DM_MOULDLogic();
        private void btn_search_Click(object sender, EventArgs e)
        {
            int allcount = 0;

            Condition c = null;
            string mdcode = txt_MDCODE.Text;
            string mdname = txt_MDNAME.Text;
            if (!String.IsNullOrEmpty(mdcode))
            {
                c &= CK.K["MDCODE"].LeftLike(mdcode);
            }
            if (!String.IsNullOrEmpty(mdname))
            {
                string[] name = mdname.Split(' ');
                foreach (string s in name) {
                    if (!String.IsNullOrEmpty(s))
                    { c &= CK.K["MDNAME"].Like(s); }   
                }                
            }
            if (c == null)
                c = Condition.Empty;

            DataTable list=mouldlogic.ExecuteSelect(c,OrderBy.Parse(""),0,0,ref allcount).ToDataTable();
            gGrid1.DataSource = list;
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
        private void InitColumn() {
            gGrid1.AddGridColumn("MDCODE", "花模代码", "String", 80);
            gGrid1.AddGridColumn("MDNAME", "花模名称", "String", 100);
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }
        private void ItemSearch_Load(object sender, EventArgs e)
        {
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
