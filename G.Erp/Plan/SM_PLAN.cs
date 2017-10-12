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
using G.BLL.ERP.Plan;
using G.BLL.ERP.Shop;
using G.Entity.SysEnt;

namespace G.Erp.Plan
{
    public partial class SM_PLAN : G.APP.BaseForm.BaseEditor
    {
        public SM_PLAN()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "生产计划";
            this.listTool = new List<string>() { "下达生产", "采购申请", "领料", "打印派工单", "预览派工单", "|", "撤销生产", "撤销采购", "|", "设置交期", "计划完成", "退出" };
            this.Logic = new G.BLL.ERP.Plan.SM_BOMTEMPLogic();
            InitGridCP();
            InitGridShop();
            InitGridZJ();
            G.BLL.ERP.BaseData.DM_GXLogic gxlogic = new G.BLL.ERP.BaseData.DM_GXLogic();
            Initialize.InitDropDown(DROP_GX, "GX", gxlogic, false);
            DROP_GX.RowSelect += DROP_GX_RowSelect;
        }
        string orderid = "";
        string gxname = "";
        void DROP_GX_RowSelect(object sender, Interface.Event.DataRowEvent e)
        {
            gxname = DROP_GX.Text;
            LoadGridCP(orderid, gxname);
            LoadGridShop(orderid, gxname);
            this.LoadGridZJ(orderid, gxname);
        }

        private void InitGridCP()
        {
            Grid_CP.AddGridColumn("ISSELECT", "选择", "Boolean", 40, false);
            Grid_CP.AddGridColumn("RDATE", "生产日期", "DateTime", 80, false);
            Grid_CP.AddGridColumn("PURDATE", "采购交期", "DateTime", 80, false);
            Grid_CP.AddGridColumn("LEFTQTY", "剩余数量", "Decimal", "#0", 80, false);
            Grid_CP.AddGridColumn("ITEMCODE", "物品代码", "String", 80, true);
            Grid_CP.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            Grid_CP.AddGridColumn("ATTRIBUTEA", "色号", "String", 100, true);
            Grid_CP.AddGridColumn("ATTRIBUTEC", "规格mm", "Decimal", "#0.0", 60, true);
            Grid_CP.AddGridColumn("ATTRIBUTEBNAME", "花模", "String", 80, true);
            Grid_CP.AddGridColumn("BOMQTY", "订单数量", "Decimal", "#0", 80, true);
            //Grid_CP.AddGridColumn("REQUIREQTY", "需求数量", "Decimal", "#0", 80, true);
            Grid_CP.AddGridColumn("DUEQTY", "生产数量", "Decimal", "#0", 60, true);
            Grid_CP.AddGridColumn("PURQTY", "采购数量", "Decimal", "#0", 60, true);
            Grid_CP.AddGridColumn("ATTRIBUTED", "款号", "String", 120, true);
            Grid_CP.AddGridColumn("MEMO", "注意事项", "String", 120, true);
            Grid_CP.AddGridColumn("PRODATE", "交期", "DateTime", 80, true);
            Grid_CP.AddGridColumn("ONHANDQTY", "有色库存", "Decimal", "#0", 80, true);
            Grid_CP.AddGridColumn("ONHANDQTY1", "白坯库存", "Decimal", "#0", 80, true);
            Grid_CP.AddGridColumn("ASSISTQTY", "已外协数", "Decimal", "#0", 80, true);

            Grid_CP.FrozenCell = 6;
            Grid_CP.AutoGenerateColumns = false;
            Grid_CP.AutoResize = true;
            Grid_CP.InitGrid();
        }
        private void InitGridShop()
        {
            Grid_SHOP.AddGridColumn("SHOPORDID", "派工单号", "String", 80, true);
            Grid_SHOP.AddGridColumn("WORKSHOP", "工序", "String", 80, true);
            Grid_SHOP.AddGridColumn("RDATE", "生产交期", "DateTime", 100, true);
            Grid_SHOP.AddGridColumn("REQQTY", "需求数量", "Decimal", "#0.0", 100, true);
            Grid_SHOP.AddGridColumn("ITEMCODE", "物品代码", "String", 80, true);
            Grid_SHOP.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            Grid_SHOP.AddGridColumn("ATTRIBUTEA", "色号", "String", 100, true);
            Grid_SHOP.AddGridColumn("ATTRIBUTEC", "规格mm", "Decimal", "#0.0", 60, true);
            Grid_SHOP.AddGridColumn("ATTRIBUTEBNAME", "花模", "String", 80, true);
            Grid_SHOP.AddGridColumn("ATTRIBUTED", "款号", "String", 120, true);
            Grid_SHOP.AddGridColumn("MEMO", "注意事项", "String", 120, true);

            Grid_SHOP.FrozenCell = 1;
            Grid_SHOP.AutoGenerateColumns = false;
            Grid_SHOP.InitGrid();
        }
        private void InitGridZJ()
        {
            Grid_ZJ.AddGridColumn("ISSELECT", "选择", "Boolean", 40, false);
            Grid_ZJ.AddGridColumn("RDATE", "生产日期", "DateTime", 80, false);
            Grid_ZJ.AddGridColumn("PURDATE", "采购交期", "DateTime", 80, false);
            Grid_ZJ.AddGridColumn("LEFTQTY", "剩余数量", "Decimal", "#0.0", 80, false);
            Grid_ZJ.AddGridColumn("FATHERITEM", "父代码", "String", 80, true);
            Grid_ZJ.AddGridColumn("FATHERITEMNAME", "父名称", "String", 100, true);
            Grid_ZJ.AddGridColumn("ITEMCODE", "子件代码", "String", 80, true);
            Grid_ZJ.AddGridColumn("ITEMNAME", "子件名称", "String", 100, true);
            Grid_ZJ.AddGridColumn("ATTRIBUTEA", "色号", "String", 100, true);
            Grid_ZJ.AddGridColumn("ATTRIBUTEC", "规格mm", "Decimal", "#0.0", 60, true);
            Grid_ZJ.AddGridColumn("ATTRIBUTEBNAME", "花模", "String", 80, true);
            Grid_ZJ.AddGridColumn("BOMQTY", "订单数量", "Decimal", "#0", 80, true);
            Grid_ZJ.AddGridColumn("DUEQTY", "生产数量", "Decimal", "#0", 60, true);
            Grid_ZJ.AddGridColumn("PURQTY", "采购数量", "Decimal", "#0", 60, true);
            Grid_ZJ.AddGridColumn("ATTRIBUTED", "款号", "String", 120, true);
            Grid_ZJ.AddGridColumn("MEMO", "注意事项", "String", 120, true);
            //Grid_ZJ.AddGridColumn("PRODATE", "交期", "DateTime", 80, true);
            Grid_ZJ.AddGridColumn("ONHANDQTY", "有色库存", "Decimal", "#0.0", 80, true);
            Grid_ZJ.AddGridColumn("ONHANDQTY1", "白坯库存", "Decimal", "#0.0", 80, true);
            Grid_ZJ.AddGridColumn("ASSISTQTY", "已外协数", "Decimal", "#0.0", 80, true);

            Grid_ZJ.FrozenCell = 8;
            Grid_ZJ.AutoGenerateColumns = false;
            Grid_ZJ.AutoResize = true;
            Grid_ZJ.InitGrid();
        }
        public override void ToolButtonClick(string name)
        {
            if (name == "下达生产")
            {
                DownPlan();
            }
            else if (name == "采购申请")
            {
                PrepurOrder();
            }
            else if (name == "领料")
            {
                AssistMsupply();
            }
            else if (name == "打印派工单")
            {
                WorkOrderPrint(true);
            }
            else if (name == "预览派工单")
            {
                WorkOrderPrint(false);
            }
            else if (name == "撤销生产")
            {
                CancelPlan();
            }
            else if (name == "撤销采购")
            {
                CancelPrepur();
            }
            else if (name == "设置交期")
            {
                SetProDate();
            }
            else if (name == "计划完成")
            {
                PlanFin();
            }
            else
            {
                base.ToolButtonClick(name);
            }
        }
        #region 计划完成
        private void PlanFin()
        {
            ((SM_BOMTEMPLogic)this.Logic).PlanFin(G.AppInfo.GGlobal.User, orderid);
        }
        #endregion

        #region 设置交期
        private void SetProDate()
        {
            try
            {
                this.Grid_CP.FinishEditing();
                string date = G.Core.GConvert.ToString(this.DATE_PLANDATE.Text);
                if (date != "" && date != null)
                {
                    List<SM_BOMTEMP> tempdata = (this.Grid_CP.DataSource as BindingList<SM_BOMTEMP>).ToList<SM_BOMTEMP>();

                    var updata = from temp in tempdata
                                 where temp.ISSELECT == true
                                 select temp;
                    foreach (SM_BOMTEMP t in updata)
                    {
                        t.PRODATE = G.Core.GConvert.ToDateTime(date);
                    }
                    DbEntry.UsingTransaction(delegate
                    {
                        ((SM_BOMTEMPLogic)this.Logic).ExecuteUpdate(G.AppInfo.GGlobal.User, updata.ToList<SM_BOMTEMP>());
                    });

                    this.LoadGridCP(orderid, gxname);
                    this.LoadGridShop(orderid, gxname);
                    this.LoadGridZJ(orderid, gxname);
                }
                else
                {
                    MessageBox.Show("没有设置交期！");
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region 下达生产
        SM_SHOPORDERLogic shoplogic = new SM_SHOPORDERLogic();
        private void DownPlan()
        {
            try
            {
                if (gxname == "")
                {
                    MessageBox.Show("没有选择工序，无法生产下达！");
                    return;
                }
                List<SM_BOMTEMP> tempdata = new List<SM_BOMTEMP>();
                G.BLL.ERP.BaseData.DM_ITEMLogic itemlogic = new G.BLL.ERP.BaseData.DM_ITEMLogic();
                if (tabControl1.SelectedIndex == 0)
                {
                    this.Grid_CP.FinishEditing();
                    tempdata = (this.Grid_CP.DataSource as BindingList<SM_BOMTEMP>).ToList<SM_BOMTEMP>();
                }
                else
                {
                    this.Grid_ZJ.FinishEditing();
                    tempdata = (this.Grid_ZJ.DataSource as BindingList<SM_BOMTEMP>).ToList<SM_BOMTEMP>();
                }
                var updata = from temp in tempdata
                             where temp.ISSELECT == true
                             select temp;
                List<SM_SHOPORDER> listshoporder = new List<SM_SHOPORDER>();
                bool nopass = true;
                foreach (SM_BOMTEMP t in updata)
                {
                    if (t.RDATE == null || t.LEFTQTY <= 0) { nopass = false; break; }
                    SM_SHOPORDER shopo = new SM_SHOPORDER();
                    shopo.ORDERID = t.ORDERID;
                    shopo.BOMTEMPID = t.Id;
                    shopo.ITEMCODE = t.ITEMCODE;
                    shopo.ATTRIBUTEA = t.ATTRIBUTEA;
                    shopo.ATTRIBUTEB = t.ATTRIBUTEB;
                    shopo.ATTRIBUTEC = t.ATTRIBUTEC;
                    shopo.REQQTY = t.LEFTQTY;
                    shopo.RDATE = t.RDATE;
                    shopo.SHPORDTYPE = "1";
                    shopo.STATUS = "N";
                    shopo.MEMO = t.MEMO;
                    shopo.ATTRIBUTED = t.ATTRIBUTED;
                    shopo.WORKSHOP = gxname;
                    listshoporder.Add(shopo);
                }
                if (nopass)
                {
                    DbEntry.UsingTransaction(delegate
                    {
                        shoplogic.ExecuteUpdate(G.AppInfo.GGlobal.User, listshoporder);
                        //((SM_BOMTEMPLogic)this.Logic).ExecuteUpdate(G.AppInfo.GGlobal.User, updata.ToList<SM_BOMTEMP>());
                    });
                }
                else { MessageBox.Show("请确定需要下达的行有【下达日期】和【计划数量】！"); }


                this.LoadGridCP(orderid, gxname);
                this.LoadGridShop(orderid, gxname);
                this.LoadGridZJ(orderid, gxname);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        #endregion

        #region 采购申请
        private void PrepurOrder()
        {
            try
            {
                SM_BOMTEMP temp = new SM_BOMTEMP();
                G.BLL.ERP.BaseData.DM_ITEMLogic itemlogic = new G.BLL.ERP.BaseData.DM_ITEMLogic();
                SM_PREPURORDER prepur = new SM_PREPURORDER();
                if (tabControl1.SelectedIndex == 0)
                {
                    this.Grid_CP.FinishEditing();
                    temp = this.Grid_CP.GetCurSelect<SM_BOMTEMP>();
                }
                else
                {
                    this.Grid_ZJ.FinishEditing();
                    temp = this.Grid_ZJ.GetCurSelect<SM_BOMTEMP>();
                }
                prepur.PREPURQTY = G.Core.GConvert.ToDecimal(temp.LEFTQTY);
                prepur.ORDERID = temp.ORDERID;
                prepur.ORDLNNO = temp.ORDLNNO;
                prepur.APPLYUSER = G.AppInfo.GGlobal.User.USERDM;
                prepur.APPLYUSERNAME = G.AppInfo.GGlobal.User.USERNAME;
                prepur.ITEMCODE = temp.ITEMCODE;
                prepur.ITEMNAME = temp.ITEMNAME;
                prepur.PURTYPE = "1";
                prepur.INVUNIT = temp.INVUNIT;
                prepur.BOMTEMPID = temp.Id;
                prepur.ATTRIBUTEA = temp.ATTRIBUTEA;
                prepur.ATTRIBUTEB = temp.ATTRIBUTEB;
                prepur.ATTRIBUTEBNAME = temp.ATTRIBUTEBNAME;
                prepur.ATTRIBUTEC = temp.ATTRIBUTEC;
                prepur.ATTRIBUTED = temp.ATTRIBUTED;
                prepur.REMARK = temp.MEMO;
                DM_ITEM itemobj = itemlogic.ExecuteSelect(CK.K["ITEMCODE"].Eq(temp.ITEMCODE), OrderBy.Parse("ITEMCODE"), 0, 0)[0];
                prepur.SUPCODE = itemobj.SUPCODE;
                prepur.SUPPRICE = itemobj.SUPPRICE;
                prepur.ISATTRIBUTEA = G.Core.GConvert.ToBool(itemobj.IsAttributeA);
                prepur.ISATTRIBUTEB = G.Core.GConvert.ToBool(itemobj.IsAttributeB);
                prepur.ISATTRIBUTEC = G.Core.GConvert.ToBool(itemobj.IsAttributeC);
                //弹出采购申请单，数据来自选择行
                Purchase.SM_PREPURORDEREDIT prepurEdit = new Purchase.SM_PREPURORDEREDIT();
                prepurEdit.SetData(prepur);
                DialogResult drst = prepurEdit.ShowDialog();
                if (drst == DialogResult.OK)
                {
                    //采购数量填入BOMTEMP
                    temp.PURQTY += temp.LEFTQTY;
                    ((SM_BOMTEMPLogic)this.Logic).ExecuteUpdate(G.AppInfo.GGlobal.User, temp);
                }
                this.LoadGridCP(orderid, gxname);
                this.LoadGridShop(orderid, gxname);
                this.LoadGridZJ(orderid, gxname);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region 领料
        private void AssistMsupply()
        {
            try
            {
                SM_BOMTEMP temp = new SM_BOMTEMP();
                G.BLL.ERP.BaseData.DM_ITEMLogic itemlogic = new G.BLL.ERP.BaseData.DM_ITEMLogic();
                SM_SHOPSUPPLY shopsupply = new SM_SHOPSUPPLY();
                shopsupply.APPLYER = G.AppInfo.GGlobal.User.USERDM;
                shopsupply.APPLYERNAME = G.AppInfo.GGlobal.User.USERNAME;
                shopsupply.APPLYDATE = DateTime.Parse(BaseExtends.GetServerDate().ToShortDateString());
                G.BLL.Sys.ND_ORGINAZITIONLogic userlogic = new BLL.Sys.ND_ORGINAZITIONLogic();
                ND_ORGINAZITION userobj = userlogic.ExecuteSelect(CK.K["ID"].Eq(G.AppInfo.GGlobal.User.ORGID), OrderBy.Parse("ORGNAME"), 0, 0)[0];
                shopsupply.WORKSHOP = userobj.ORGDM;
                shopsupply.ORGNAME = userobj.ORGNAME;

                SM_SHOPSUPPLYDTL dtl = new SM_SHOPSUPPLYDTL();
                if (tabControl1.SelectedIndex == 0)
                {
                    this.Grid_CP.FinishEditing();
                    temp = this.Grid_CP.GetCurSelect<SM_BOMTEMP>();
                    dtl.ACTQTY = G.Core.GConvert.ToDecimal(temp.LEFTQTY);
                }
                else
                {
                    this.Grid_ZJ.FinishEditing();
                    temp = this.Grid_ZJ.GetCurSelect<SM_BOMTEMP>();
                    DM_ITEM itemobj1 = itemlogic.ExecuteSelect(CK.K["ITEMCODE"].Eq(temp.FATHERITEM), OrderBy.Parse("ITEMCODE"), 0, 0)[0];
                    if (temp.FATHERITEM.Substring(0, 4) == "S1LS")
                    {
                        dtl.ACTQTY = G.Core.GConvert.ToDecimal(temp.LEFTQTY * itemobj1.ISIZE / 100);
                    }
                    else
                    {
                        dtl.ACTQTY = G.Core.GConvert.ToDecimal(temp.LEFTQTY);
                    }
                }
                dtl.ITEMCODE = temp.ITEMCODE;
                dtl.ITEMNAME = temp.ITEMNAME;
                dtl.UNIT = temp.INVUNIT;
                dtl.ATTRIBUTEA = temp.ATTRIBUTEA;
                dtl.ATTRIBUTEB = temp.ATTRIBUTEB;
                dtl.ATTRIBUTEBNAME = temp.ATTRIBUTEBNAME;
                dtl.ATTRIBUTEC = temp.ATTRIBUTEC;
                dtl.ATTRIBUTED = temp.ATTRIBUTED;
                dtl.MEMO = temp.MEMO;
                dtl.BOMTEMPID = temp.Id;
                DM_ITEM itemobj = itemlogic.ExecuteSelect(CK.K["ITEMCODE"].Eq(temp.ITEMCODE), OrderBy.Parse("ITEMCODE"), 0, 0)[0];
                dtl.ISATTRIBUTEA = G.Core.GConvert.ToBool(itemobj.IsAttributeA);
                dtl.ISATTRIBUTEB = G.Core.GConvert.ToBool(itemobj.IsAttributeB);
                dtl.ISATTRIBUTEC = G.Core.GConvert.ToBool(itemobj.IsAttributeC);

                shopsupply.SHOPSUPPLYDTL.Add(dtl);
                //弹出外协领料单，数据来自选择行
                Storage.SM_SHOPSUPPLYEDIT edit = new Storage.SM_SHOPSUPPLYEDIT();
                edit.CurEditStatus = EditorStatus.Modify;
                edit.SetData(shopsupply);
                edit.ShowDialog();

                this.LoadGridCP(orderid, gxname);
                this.LoadGridShop(orderid, gxname);
                this.LoadGridZJ(orderid, gxname);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region 打印派工单
        public void WorkOrderPrint(bool isPrint)
        {
            try
            {
                    string condition = string.Format("WORKSHOP='{0}' AND A.ORDERID='{1}'", gxname, orderid);
                    G.Controls.Printer.PrintHelper printobj = new G.Controls.Printer.PrintHelper(@"\Shop\WORKORDER.frx", new List<string>() { "QryMaster" }, "workorderprint", condition);
                    printobj.Print(isPrint);
                    if (!isPrint) return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 撤销生产
        private void CancelPlan()
        {
            try
            {
                Data.SqlEntry.SqlStatement sql = new Data.SqlEntry.SqlStatement(string.Format("exec SMProc_CancelPlan '{0}','{1}'", orderid, G.AppInfo.GGlobal.User.USERDM));
                DbEntry.Provider.ExecuteNonQuery(sql);
                this.LoadGridCP(orderid, gxname);
                this.LoadGridShop(orderid, gxname);
                this.LoadGridZJ(orderid, gxname);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        #endregion

        #region 撤销采购
        private void CancelPrepur()
        {
            try
            {
                Data.SqlEntry.SqlStatement sql = new Data.SqlEntry.SqlStatement(string.Format("exec SMProc_CancelPrepur '{0}','{1}'", orderid, G.AppInfo.GGlobal.User.USERDM));
                DbEntry.Provider.ExecuteNonQuery(sql);
                this.LoadGridCP(orderid, gxname);
                this.LoadGridShop(orderid, gxname);
                this.LoadGridZJ(orderid, gxname);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        #endregion

        public void SetPara(SM_SALEORDER order)
        {
            orderid = order.ORDERID;
            this.TXT_ORDERID.SetValue(order.ORDERID);
            this.TXT_ORDERTYPE.SetValue(order.ORDERTYPENAME);
            this.TXT_CUSTNAME.SetValue(order.CUSTNAME);
            LoadGridCP(orderid, "");
            LoadGridShop(orderid, "");
            this.LoadGridZJ(orderid, "");
        }
        private void LoadGridCP(string orderid, string gxname)
        {
            List<SM_BOMTEMP> list = ((SM_BOMTEMPLogic)this.Logic).GetBomTempDataByGx(G.AppInfo.GGlobal.User, orderid, gxname, 1);
            this.Grid_CP.SetValue<SM_BOMTEMP>(list);
        }
        private void LoadGridShop(string orderid, string gxname)
        {
            Condition c = CK.K["ORDERID"].Eq(orderid) & CK.K["WORKSHOP"].Eq(gxname);
            List<SM_SHOPORDER> list = this.shoplogic.ExecuteSelect(G.AppInfo.GGlobal.User, c, OrderBy.Parse("RDATE"), 0, 0);
            this.Grid_SHOP.SetValue<SM_SHOPORDER>(list);
        }
        private void LoadGridZJ(string orderid, string gxname)
        {
            List<SM_BOMTEMP> list = ((SM_BOMTEMPLogic)this.Logic).GetBomTempDataByGx(G.AppInfo.GGlobal.User, orderid, gxname, 2);
            this.Grid_ZJ.SetValue<SM_BOMTEMP>(list);
        }
    }
}
