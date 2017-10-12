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
using G.APP.BaseForm;

namespace G.Erp.BaseData
{
    public partial class SM_PROCESSFLOWEDIT : G.APP.BaseForm.BaseMultipleEditor
    {
        public SM_PROCESSFLOWEDIT()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "工艺流程";
            this.listTool = new List<string>() { "增行", "删行", "-", "损耗率", "-", "保存", "|", "退出" };
            this.Logic = new G.BLL.ERP.BaseData.SM_ITEMROUTINGLogic();
            InitGrid();
        }

        public override void InitGrid()
        {
            DropDown dropGX = new DropDown();
            Initialize.InitDropDown(dropGX, "GX", new G.BLL.ERP.BaseData.DM_GXLogic(), "ID", "GXNAME");

            gGrid1.AddGridColumn("SORTID", "序号", "Int32", 40, true);
            gGrid1.AddGridColumn("ITEMTYPENAME", "物品类型", "String", 120, true);
            gGrid1.AddGridColumn("GXID", "工序", "Int32", 100, dropGX, "GXNAME");
            gGrid1.AddGridColumn("ISASSIST", "是否外协", "Boolean", 60);
            gGrid1.FrozenCell = 2;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }

        int itemtypeid = 0;
        string itemtypename = "";
        public void SetPara(SM_ITEMTYPE itemtype)
        {
            itemtypeid = itemtype.Id;
            itemtypename = itemtype.ITEMTYPENAME;
            //this.TXT_ORDERID.SetValue(order.ORDERID);
            LoadGrid();
        }
        List<SM_ITEMROUTING> list = null;
        private void LoadGrid()
        {
            Condition c = CK.K["ITEMTYPEID"].Eq(itemtypeid);
            list = ((SM_ITEMROUTINGLogic)this.Logic).ExecuteSelect(G.AppInfo.GGlobal.User, c, OrderBy.Parse("SORTID"), 0, 0);
            this.gGrid1.SetValue<SM_ITEMROUTING>(list);
        }

        int i = 0;
        public override void AddRow()
        {
            try
            {
                if (i == 1)
                {
                    int sortid = list.Count + 1;
                    SM_ITEMROUTING processflow = gGrid1.AddRow<SM_ITEMROUTING>();
                    processflow.SORTID = sortid;
                    processflow.ITEMTYPEID = itemtypeid;
                    processflow.ITEMTYPENAME = itemtypename;
                    sortid++;
                }
                i = 1;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public override void DeleteRow()
        {
            try
            {
                gGrid1.DeleteRow<SM_ITEMROUTING>();               
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public override void onBeforeSave()
        {
            int sortid = 1;
            this.gGrid1.FinishEditing();
            List<SM_ITEMROUTING> list = ((BindingList<SM_ITEMROUTING>)gGrid1.GetValue()).ToList<SM_ITEMROUTING>();
            foreach (SM_ITEMROUTING s in list)
                {
                    s.SORTID = sortid;
                    sortid++;
                }
            base.onBeforeSave();
        }
        public override bool Save()
        {
            bool ispass = false;
            try
            {
                onBeforeSave();
                List<SM_ITEMROUTING> list = ((BindingList<SM_ITEMROUTING>)gGrid1.GetValue()).ToList<SM_ITEMROUTING>();
                List<SM_ITEMROUTING> deletelist = gGrid1.getDeleteRows<SM_ITEMROUTING>();
                ((SM_ITEMROUTINGLogic)this.Logic).ExecuteUpdate(G.AppInfo.GGlobal.User, list, deletelist);
                MessageBox.Show("保存成功！");
                this.LoadData();
                ispass = true;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return ispass;
        }

        public override void ToolButtonClick(string name)
        {
            switch (name)
            {
                case "损耗率":
                    this.WASTING();
                    break;
            }
            base.ToolButtonClick(name);
        }
        private void WASTING()
        {
            SM_ITEMROUTING itemrouting = this.gGrid1.GetCurSelect<SM_ITEMROUTING>();
            if (itemrouting != null)
            {
                SM_ITEMROUTINGWASTINGEDIT oform = new SM_ITEMROUTINGWASTINGEDIT();
                oform.CurEditStatus = EditorStatus.Modify;
                oform.SetPara(itemrouting);
                oform.ShowDialog();
            }
        }
    }
}
