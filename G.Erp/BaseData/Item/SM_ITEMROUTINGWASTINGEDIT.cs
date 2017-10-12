using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using G.BLL.ERP.BaseData;
using G.Controls.Base;
using G.Controls.Input;
using G.Data;
using G.Entity.ERP;
using System.Linq;
using System;

namespace G.Erp.BaseData
{
    public partial class SM_ITEMROUTINGWASTINGEDIT : G.APP.BaseForm.BaseMultipleEditor
    {
        public SM_ITEMROUTINGWASTINGEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "工序损耗率";
            this.listTool = new List<string>() { "增行", "删行", "-", "保存", "|", "退出" };
            this.Logic = new G.BLL.ERP.BaseData.SM_ITEMROUTINGWASTINGLogic();
            InitGrid();
        }

        public override void InitGrid()
        {
            gGrid1.AddGridColumn("ITEMTYPENAME", "物品类型", "String", 120, true);
            gGrid1.AddGridColumn("GXNAME", "物品类型", "String", 100, true);
            gGrid1.AddGridColumn("FQTY", "起始数", "Int32", 80, false);
            gGrid1.AddGridColumn("TQTY", "终止数", "Int32", 80, false);
            gGrid1.AddGridColumn("WASTING", "损耗率", "Decimal", 60,false);
            gGrid1.FrozenCell = 2;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        int itemrountingid = 0;
        string itemtypename = "";
        string gxname = "";
        public void SetPara(SM_ITEMROUTING itemrouting)
        {
            itemrountingid = itemrouting.Id;
            itemtypename = itemrouting.ITEMTYPENAME;
            gxname = itemrouting.GXNAME;
            //this.TXT_ORDERID.SetValue(order.ORDERID);
            LoadGrid();
        }
        List<SM_ITEMROUTINGWASTING> list = null;
        private void LoadGrid()
        {
            Condition c = CK.K["ITEMROUTINGID"].Eq(itemrountingid);
            list = ((SM_ITEMROUTINGWASTINGLogic)this.Logic).ExecuteSelect(G.AppInfo.GGlobal.User, c, OrderBy.Parse("FQTY"), 0, 0);
            this.gGrid1.SetValue<SM_ITEMROUTINGWASTING>(list);
        }

        public override void AddRow()
        {
            try
            {
                SM_ITEMROUTINGWASTING wasting = gGrid1.AddRow<SM_ITEMROUTINGWASTING>();
                wasting.ITEMROUTINGID = itemrountingid;
                wasting.ITEMTYPENAME = itemtypename;
                wasting.GXNAME = gxname;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public override void DeleteRow()
        {
            try
            {
                gGrid1.DeleteRow<SM_ITEMROUTINGWASTING>();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public override bool Save()
        {
            bool ispass = false;
            try
            {
                onBeforeSave();
                List<SM_ITEMROUTINGWASTING> list = ((BindingList<SM_ITEMROUTINGWASTING>)gGrid1.GetValue()).ToList<SM_ITEMROUTINGWASTING>();
                List<SM_ITEMROUTINGWASTING> deletelist = gGrid1.getDeleteRows <SM_ITEMROUTINGWASTING>();
                ((SM_ITEMROUTINGWASTINGLogic)this.Logic).ExecuteUpdate(G.AppInfo.GGlobal.User, list,deletelist);
                MessageBox.Show("保存成功！");
                this.LoadData();
                ispass = true;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return ispass;
        }
    }
}
