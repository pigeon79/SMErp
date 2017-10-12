using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Entity.ERP;
using C1.Win.C1Input;
using G.Controls.Base;
using G.Data;

namespace G.Erp.BaseData
{
    public partial class DM_ITEMEDIT : BasicForm
    {
        public DM_ITEMEDIT()
        {
            InitializeComponent();
        }

        private void EDIT_Load(object sender, EventArgs e)
        {
            this.Text = "物品";
            this.c1SplitterPanel1.Text = "物品";
            InitToolBar();
            this.drop_WRHSCODE.Logic = new G.BLL.ERP.BaseData.DM_WAREHOUSELogic();
            drop_WRHSCODE.AddGridColumn("WRHSCODE", "仓库代码", "String", 80);
            drop_WRHSCODE.AddGridColumn("WRHSNAME", "仓库名称", "String", 80);
            this.drop_WRHSCODE.GridEndInit();

            this.drop_LOCCODE.Logic = new G.BLL.ERP.BaseData.DM_LOCATIONLogic();
            drop_LOCCODE.AddGridColumn("LOCCODE", "库位代码", "String", 80);
            drop_LOCCODE.AddGridColumn("LOCNAME", "库位名称", "String", 80);
            this.drop_LOCCODE.GridEndInit();

            this.drop_InvClassID.Logic = new G.BLL.ERP.BaseData.DM_INVCLASSLogic();
            drop_InvClassID.AddGridColumn("InvClass", "类别代码", "String", 80);
            drop_InvClassID.AddGridColumn("InvDesc", "类别名称", "String", 80);
            this.drop_InvClassID.GridEndInit();

            this.DROP_ITEMTYPE.Logic = new G.BLL.ERP.BaseData.SM_ITEMTYPELogic();
            DROP_ITEMTYPE.AddGridColumn("Id", "ID", "Int32", 80);
            DROP_ITEMTYPE.AddGridColumn("ITEMTYPENAME", "类别名称", "String", 80);
            this.DROP_ITEMTYPE.GridEndInit();

            this.DROP_SUPCODE.Logic = new G.BLL.ERP.BaseData.DM_SUPPLIERLogic();
            DROP_SUPCODE.AddGridColumn("SUPPCODE", "供应商代码", "String", 80);
            DROP_SUPCODE.AddGridColumn("SUPPNAME", "供应商名称", "String", 80);
            this.DROP_SUPCODE.GridEndInit();
            LoadData();
        }
        EditorAdapter<DM_ITEM, object> eadapter = new EditorAdapter<DM_ITEM, object>();
        public override bool LoadForm()
        {
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "物品代码", FieldName = "ItemCode", Editor = this.txt_ITEMCODE });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "物品名称", FieldName = "ItemDesc", Editor = this.txt_ITEMDESC });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "物品简称", FieldName = "ItemName", Editor = this.txt_ITEMNAME });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "默认仓库", FieldName = "WrhsCode", Editor = this.drop_WRHSCODE });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "默认库位", FieldName = "LocCode", Editor = this.drop_LOCCODE });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "辅助码", FieldName = "Py", Editor = this.txt_HelpMarker });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "计量单位", FieldName = "InvUnit", Editor = this.txt_InvUnit });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "库存类别", FieldName = "InvClassID", Editor = this.drop_InvClassID });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "财务类别", FieldName = "FinaClassID", Editor = this.drop_FinaClassID });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "物品类型", FieldName = "ItemType", Editor = this.DROP_ITEMTYPE });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否色号", FieldName = "IsAttributeA", Editor = this.check_IsAttributeA });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否花模", FieldName = "IsAttributeB", Editor = this.check_IsAttributeB });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否尺寸", FieldName = "IsAttributeC", Editor = this.check_IsAttributeC });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否检验", FieldName = "QltFlag", Editor = this.check_QltFlag });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "车间", FieldName = "OrgDm", Editor = this.drop_OrgDm });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "折率", FieldName = "BreakPer", Editor = this.txt_BreakPer });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "最大库存", FieldName = "MaxStock", Editor = this.txt_MaxStock });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "安全库存", FieldName = "SafeStock", Editor = this.txt_SafeStock });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "最大产能", FieldName = "MaxCap", Editor = this.txt_MaxCap });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "合格证批量", FieldName = "CertQty", Editor = this.txt_CertQty });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "派工单批量", FieldName = "WorkOrdQty", Editor = this.txt_WorkOrdQty });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "供应商", FieldName = "SUPCODE", Editor = this.DROP_SUPCODE });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "供应商单价", FieldName = "SUPPRICE", Editor = this.NUM_SUPPRICE });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "材料名称", FieldName = "METNAME", Editor = this.TXT_METNAME });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "克重", FieldName = "WEIGHT", Editor = this.NUM_WEIGHT });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "规格", FieldName = "ISIZE", Editor = this.NUM_ISIZE });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "废料比列", FieldName = "SCRAPRATE", Editor = this.NUM_SCRAPRATE });
            eadapter.AddEditorInfo(new EditorInfo() { FieldCaption = "是否采购", FieldName = "ISPUR", Editor = this.CHECK_ISPUR });
            return true;
        }
        public void SetData(DM_ITEM data)
        {
            editData = data;
            LoadData();
        }
        private void InitToolBar()
        {
            this.gToolBar1.AddButton("新增");
            this.gToolBar1.AddButton("子件",Application.StartupPath + @"\Images\ToolBar\list.ico");
            this.gToolBar1.AddButton("保存");
            this.gToolBar1.AddButton("退出");
            this.gToolBar1.ButtonClick = new Controls.GToolBar.GToolBar.FunButtonClick(name =>
            {
                switch (name)
                {
                    case "新增":
                        this.New();
                        break;
                    case "保存":
                        this.Save();
                        break;
                    case "子件":
                        this.SplitItem();
                        break;
                    case "退出":
                        BasicForm f = this.ParentForm as BasicForm;
                        this.Close();
                        break;
                    default:
                        break;
                }
            });
        }
        private void SplitItem() {
            
            if (editData.Id > 0)
            {
                if (editData.ItemCode.Length == 8 && (editData.ItemCode.Substring(0,1)=="W"||editData.ItemCode.Substring(0,1)=="S"))
                {
                    DM_ITEMESPLITDIT splitedit = new DM_ITEMESPLITDIT();
                    splitedit.FatherItem = editData;
                    splitedit.ShowDialog();
                }
            }
            else {
                MessageBox.Show("请先保存当前物品，再拆分!");
            }

        }
        DM_ITEM editData = new DM_ITEM();
        private void LoadData()
        {
            eadapter.SetData(editData);           
        }
        private void New() {
            editData = new DM_ITEM();
            this.LoadData();
        }
        private void Save() {
            try
            {
                DateTime dt1 = DateTime.Now;
                editData = eadapter.GetData();
                DateTime dt2 = DateTime.Now;
                G.BLL.ERP.BaseData.DM_ITEMLogic logic = new BLL.ERP.BaseData.DM_ITEMLogic();
                logic.ExecuteUpdate(editData);
                DateTime dt3 = DateTime.Now;
                string info = string.Format("总时间{0},获取时间{1},保存时间{2}", (dt3 - dt1).TotalSeconds,(dt2 - dt1).TotalSeconds, (dt3 - dt2).TotalSeconds);
                G.AppInfo.GGlobal.SetInfo(info);
                MessageBox.Show("保存成功！");
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void drop_WRHSCODE_ValueChanged(object sender, EventArgs e)
        {
            this.drop_LOCCODE.ClearValue();
            this.drop_LOCCODE.DefaultCondition = CK.K["WRHSCODE"].Eq(drop_WRHSCODE.Value);
        }

        private void txt_ITEMDESC_ValueChanged(object sender, EventArgs e)
        {
            this.txt_HelpMarker.Text = G.Core.PinYin.GetCodeString(this.txt_ITEMDESC.Text);
            this.txt_ITEMNAME.Text = this.txt_ITEMDESC.Text;
        }

        private void check_IsAttributeC_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
