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
    public partial class DM_ITEMESPLITDIT : BasicForm
    {
        public DM_ITEMESPLITDIT()
        {
            InitializeComponent();
        }
        G.BLL.ERP.BaseData.DM_ITEMSPLITLogic logic = new BLL.ERP.BaseData.DM_ITEMSPLITLogic();
        private void EDIT_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "BOM分解";
                this.lab_title.Text = "BOM分解";
                InitToolBar();
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public override bool LoadForm()
        {
            return true;
        }
        private DM_ITEM fatheritem;
        public DM_ITEM FatherItem
        {
            get { return fatheritem; }
            set { fatheritem = value; }
        }
        private void InitToolBar()
        {
            this.gToolBar1.AddButton("保存");
            this.gToolBar1.AddButton("退出");
            this.gToolBar1.ButtonClick = new Controls.GToolBar.GToolBar.FunButtonClick(name =>
            {
                switch (name)
                {
                    case "保存":
                        this.Save();
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
        DM_ITEMSPLIT editData = new DM_ITEMSPLIT();
        DM_ITEM itema = null;
        DM_ITEM itemb = null;
        DM_ITEM itemc = null;
        DM_ITEM itemd = null;
        private void LoadData()
        {
            this.txt_ITEMCODE.Text = fatheritem.ItemCode; this.txt_ITEMDESC.Text = fatheritem.ItemDesc;
            int allcount = 0;
            List<DM_ITEMSPLIT> list = logic.GetData(CK.K["ItemCode"].Eq(this.fatheritem.ItemCode), OrderBy.Parse("ID"), 0, 0, ref allcount);
            if (list.Count == 1)
            {
                editData = list[0];
                txt_ItemCodeA.Text = editData.ItemCodeA;
                txt_ItemCodeB.Text = editData.ItemCodeB;
                txt_ItemCodeC.Text = editData.ItemCodeC;
                txt_ItemCodeD.Text = editData.ItemCodeD;

                txt_ItemDescA.Text = editData.ItemDescA;
                txt_ItemDescB.Text = editData.ItemDescB;
                txt_ItemDescC.Text = editData.ItemDescC;
                txt_ItemDescD.Text = editData.ItemDescD;
                //check_Bmould.Checked = G.Core.GConvert.ToBool(this.editData.IsAttributeB);

                if (!editData.ItemCodeA.IsNullOrEmpty()) { check_IsA.Checked = true; }
                if (!editData.ItemCodeB.IsNullOrEmpty()) { check_IsB.Checked = true; }
                if (!editData.ItemCodeC.IsNullOrEmpty()) { check_IsC.Checked = true; }
                if (!editData.ItemCodeD.IsNullOrEmpty()) { check_IsD.Checked = true; }
            }

        }
        private void Save()
        {
            try
            {
                editData.ItemCode = txt_ITEMCODE.Text;
                editData.ItemCodeA = txt_ItemCodeA.Text;
                editData.ItemCodeB = txt_ItemCodeB.Text;
                editData.ItemCodeC = txt_ItemCodeC.Text;
                editData.ItemCodeD = txt_ItemCodeD.Text;
                if (itema != null)
                {
                    itema.IsAttributeA = true;
                    itema.IsAttributeB = true;
                    itema.IsAttributeC = true;
                }
                if (itemb != null)
                {
                    itemb.IsAttributeA = true;
                    itemb.IsAttributeB = check_Bmould.Checked;
                }
                    logic.Save(editData, itema, itemb, itemc, itemd);
                    MessageBox.Show("保存成功！");
                
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void check_IsA_CheckedChanged(object sender, EventArgs e)
        {
            if (check_IsA.Checked)
            {
                txt_ItemCodeA.Text = GenerateCode("A", fatheritem.ItemCode);
                txt_ItemDescA.Text = GenerateDesc("A", fatheritem.ItemCode, fatheritem.ItemName);
                itema = getitems(fatheritem, txt_ItemCodeA.Text, txt_ItemDescA.Text);
            }
            else
            {
                txt_ItemCodeA.Text = ""; txt_ItemDescA.Text = "";
                itema = null;
            }
        }

        private void check_IsB_CheckedChanged(object sender, EventArgs e)
        {
            if (check_IsB.Checked)
            {
                txt_ItemCodeB.Text = GenerateCode("B", fatheritem.ItemCode);
                txt_ItemDescB.Text = GenerateDesc("B", fatheritem.ItemCode, fatheritem.ItemName);
                itemb = getitems(fatheritem, txt_ItemCodeB.Text, txt_ItemDescB.Text);
                check_Bmould.Checked = (bool)itemb.IsAttributeB;
            }
            else { txt_ItemCodeB.Text = ""; txt_ItemDescB.Text = ""; itemb = null; }
        }

        private void check_IsC_CheckedChanged(object sender, EventArgs e)
        {
            if (check_IsC.Checked)
            {
                txt_ItemCodeC.Text = GenerateCode("C", fatheritem.ItemCode);
                txt_ItemDescC.Text = GenerateDesc("C", fatheritem.ItemCode, fatheritem.ItemName);
                itemc = getitems(fatheritem, txt_ItemCodeC.Text, txt_ItemDescC.Text);
            }
            else { txt_ItemCodeC.Text = ""; txt_ItemDescC.Text = ""; itemc = null; }
        }

        private void check_IsD_CheckedChanged(object sender, EventArgs e)
        {
            if (check_IsD.Checked)
            {
                txt_ItemCodeD.Text = GenerateCode("D", fatheritem.ItemCode);
                txt_ItemDescD.Text = GenerateDesc("D", fatheritem.ItemCode, fatheritem.ItemName);
                itemd = getitems(fatheritem, txt_ItemCodeD.Text, txt_ItemDescD.Text);
            }
            else { txt_ItemCodeD.Text = ""; txt_ItemDescD.Text = ""; itemd = null; }
        }
        private string GenerateCode(string type, string itemcode)
        {
            string zjitemcode = "";
            try
            {
                string tt = itemcode.Substring(2, 2).ToUpper();
                string lc = itemcode.Substring(itemcode.Length-1, 1).ToUpper();//高低边包边处理
                string itemcodenew = itemcode.Substring(0, itemcode.Length - 1);
                switch (type)
                {
                    case "A":
                        if (tt == "SB")
                        {
                            if (lc == "1" || lc == "3")//A件高边
                            {
                                zjitemcode = "W1SB0001A";
                            }
                            else
                            {
                                zjitemcode = "W1SB0000A";
                            }
                        }
                        else if (tt == "XK")
                        { 
                            zjitemcode = itemcodenew + "0" + type;
                        }
                        else
                        {
                            zjitemcode = itemcode + type;
                        }
                        break;
                    case "B":
                        if (tt == "RV")
                        {
                            zjitemcode = string.Format("W1RV00{0}B", itemcode.Substring(itemcode.Length - 2, 2).ToUpper());
                        }
                        else if (tt == "XK" || tt == "SB")
                        {
                            zjitemcode = itemcodenew + "0" + type;
                        }
                        else
                        {
                            zjitemcode = itemcode + type;
                        }
                        break;
                    case "D":
                        if (tt == "SB")
                        {
                            if (lc == "2" || lc == "3")//D件包面
                            {
                                zjitemcode = itemcodenew + "1" + type;
                            }
                            else
                            {
                                zjitemcode = itemcodenew + "0" + type;
                            }
                        }
                        else
                        {
                            zjitemcode = itemcode + type;
                        }
                        break;
                    default:
                        if (tt == "XK" || tt == "SB")
                        {
                            zjitemcode = itemcodenew + "0" + type;
                        }
                        else
                        {
                            zjitemcode = itemcode + type;
                        }
                        break;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return zjitemcode;
        }
        private string GenerateDesc(string type, string itemcode, string itemdesc)
        {
            string tt = itemcode.Substring(2, 2).ToUpper();
            string desc = "", zjdesc = "";
            switch (type)
            {
                case "A":
                    switch (tt)
                    {
                        case "SB":
                            zjdesc = "四合扣-钮面";
                            break;
                        case "XK":
                        case "XD":
                        case "PB":
                            desc = "-钮面";
                            break;
                        case "JB":
                        case "RV":
                        case "PS":
                            desc = "-面";
                            break;
                        case "EL":
                            desc = "-鸡眼";
                            break;
                        case "SK":
                        case "YD":
                        case "KJ":
                        case "LS":
                            desc = "-A";
                            break;
                    }
                    break;
                case "B":
                    switch (tt)
                    {
                        case "SB":
                        case "XK":
                        case "XD":
                        case "PB":
                        case "PS":
                            desc = "-弹件";
                            break;
                        case "JB":
                        case "RV":
                            string sl = itemcode.Substring(7, 1).ToUpper();
                            if (sl == "T") zjdesc = "铜撞钉-钉";
                            else if (sl == "L") zjdesc = "铝撞钉-钉";
                            else zjdesc = itemdesc + "-钉";
                            break;
                        case "EL":
                            desc = "-介子";
                            break;
                        case "SK":
                        case "YD":
                        case "KJ":
                        case "LS":
                            desc = "-B";
                            break;
                    }
                    break;
                case "C":
                    switch (tt)
                    {
                        case "SB":
                        case "XK":
                        case "XD":
                        case "PS":
                            desc = "-钮珠";
                            break;
                        case "SK":
                            desc = "-弹簧";
                            break;
                        case "LS":
                            desc = "-C";
                            break;
                    }
                    break;
                case "D":
                    switch (tt)
                    {
                        case "SB":
                        case "XK":
                        case "XD":
                        case "PS":
                            desc = "-底笛";
                            break;
                    }
                    break;
            }
            if (!desc.IsNullOrEmpty() && zjdesc == "") { zjdesc = itemdesc + desc; }
            return zjdesc;
        }

        G.BLL.ERP.BaseData.DM_ITEMLogic itemlogic = new BLL.ERP.BaseData.DM_ITEMLogic();
        private DM_ITEM getitems(DM_ITEM item, string itemcode, string itemname)
        {
            DM_ITEM itemn = null;
            if (!itemcode.IsNullOrEmpty())
            {
                itemn = itemlogic.FindObject(CK.K["ItemCode"].Eq(itemcode));
                if (itemn == null)
                {
                    itemn = new DM_ITEM();

                }
                itemn.ItemCode = itemcode;
                itemn.ItemDesc = itemname;
                itemn.ItemName = itemname;
                itemn.ItemType = item.ItemType;
                itemn.ItemTypeID = item.ItemTypeID;
                itemn.WrhsCode = item.WrhsCode;
                itemn.LocCode = item.LocCode;
                itemn.InvUnit = "个";
                itemn.Operator = G.AppInfo.GGlobal.User.USERDM;
                itemn.Py = G.Core.PinYin.GetCodeString(itemname);
            }
            return itemn;
        }

        private void txt_ItemCodeB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var list = itemlogic.ExecuteSelect(CK.K["ITEMCODE"].Eq(txt_ItemCodeB.Text), OrderBy.Parse("ITEMCODE"), 20, 0);
                if (list.Count > 0)
                {
                    txt_ItemDescB.Text = list[0].ItemName;
                    itemb = list[0];
                }
            }
        }
    }
}
