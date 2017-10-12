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
using G.Entity.SysEnt;

namespace G.Erp.Plan
{
    public partial class SM_ASSISTPLAN : G.APP.BaseForm.BaseEditor
    {
        public SM_ASSISTPLAN()
        {
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            this.listCaption = "外协计划";
            this.listTool = new List<string>() { "对库完成转车间", "外协全部完成", "-", "外协领料单", "成品领料", "|", "退出" };
            this.Logic = new G.BLL.ERP.Plan.SM_BOMTEMPLogic();
            InitGrid1();
        }

        private void InitGrid1()
        {
            gGrid1.AddGridColumn("ISSELECT", "选择", "Boolean", 50, false);
            gGrid1.AddGridColumn("ASSISTDATE", "外协交期", "DateTime", 80, false);
            gGrid1.AddGridColumn("UNASSISTQTY", "未完成数", "Decimal", "#0.0", 80, false);
            //gGrid1.AddGridColumn("ITEMCODE", "物品代码", "String", 80, true);
            gGrid1.AddGridColumn("ITEMNAME", "物品名称", "String", 100, true);
            gGrid1.AddGridColumn("ATTRIBUTEA", "色号", "String", 60, true);
            gGrid1.AddGridColumn("ATTRIBUTEC", "规格mm", "Decimal", "#0.0", 60, true);
            gGrid1.AddGridColumn("ATTRIBUTEBNAME", "花模", "String", 80, true);
            gGrid1.AddGridColumn("BOMQTY", "订单数量", "Decimal", "#0.0", 80, true);
            gGrid1.AddGridColumn("REQUIREQTY", "需求数量", "Decimal", "#0.0", 80, true);
            gGrid1.AddGridColumn("ONHANDQTY", "有色库存", "Decimal", "#0.0", 80, true);
            gGrid1.AddGridColumn("ONHANDQTY1", "白坯库存", "Decimal", "#0.0", 80, true);
            gGrid1.AddGridColumn("ASSISTQTY", "已外协数", "Decimal", "#0.0", 80, true);
            gGrid1.AddGridColumn("ATTRIBUTED", "款号", "String", 100, true);
            gGrid1.AddGridColumn("MEMO", "注意事项", "String", 120, true);
            

            gGrid1.FrozenCell = 3;
            gGrid1.AutoGenerateColumns = false;
            gGrid1.InitGrid();
        }
        public override void ToolButtonClick(string name)
        {
            try
            {
                if (name == "对库完成转车间")
                {
                    ((SM_BOMTEMPLogic)this.Logic).AssistFirstDown(G.AppInfo.GGlobal.User, saleorder.ORDERID);
                    this.Close();
                }
                else if (name == "外协全部完成")
                {
                    ((SM_BOMTEMPLogic)this.Logic).AssistAllDown(G.AppInfo.GGlobal.User, saleorder.ORDERID);
                }
                else if (name == "外协领料单")
                {
                    AssistSupply();
                    LoadGrid1(saleorder.ORDERID);
                }
                else if (name == "成品领料")
                {
                    ShopSupply();
                }
                else
                {
                    base.ToolButtonClick(name);
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

        }
        private void AssistSupply()
        {
            try
            {
                this.gGrid1.FinishEditing();
                List<SM_BOMTEMP> tempdata = (this.gGrid1.DataSource as BindingList<SM_BOMTEMP>).ToList<SM_BOMTEMP>();

                var updata = from temp in tempdata
                             where temp.ISSELECT == true
                             select temp;

                SM_ASSISTMSUPPLY asupply = new SM_ASSISTMSUPPLY();
                asupply.ASSISTMSUPPLYDTL.Clear();
                asupply.ORDERID = saleorder.ORDERID;
                asupply.ACUSTID = saleorder.CUSTID;
                asupply.SALESMANNAME = saleorder.SALESMANNAME;
                asupply.SALESREPNAME = saleorder.SALESREPNAME;
                foreach (SM_BOMTEMP t in updata)
                {
                    SM_ASSISTMSUPPLYDTL dtl = new SM_ASSISTMSUPPLYDTL();
                    dtl.ITEMCODE = t.ITEMCODE;
                    dtl.ITEMNAME = t.ITEMNAME;
                    dtl.UNIT = t.INVUNIT;
                    dtl.ATTRIBUTEA = t.ATTRIBUTEA;
                    dtl.ATTRIBUTEB = t.ATTRIBUTEB;
                    dtl.ATTRIBUTEBNAME = t.ATTRIBUTEBNAME;
                    dtl.ATTRIBUTEC = t.ATTRIBUTEC;
                    dtl.ATTRIBUTED = t.ATTRIBUTED;
                    dtl.PLANQTY = t.UNASSISTQTY;
                    dtl.FACTQTY = t.UNASSISTQTY;
                    dtl.BOMTEMPID = t.Id;
                    dtl.NEEDING = t.MEMO;
                    asupply.ASSISTMSUPPLYDTL.Add(dtl);
                }

                Assist.SM_ASSISTMSUPPLYEDIT asistEdit = new Assist.SM_ASSISTMSUPPLYEDIT();
                asistEdit.CurEditStatus = EditorStatus.Modify;
                asistEdit.SetData(asupply);
                asistEdit.ShowDialog();

                foreach (SM_BOMTEMP t in updata)
                {
                    if (t.UNASSISTQTY <= t.ONHANDQTY)
                    {
                        t.ASSISTQTY = G.Core.GConvert.ToDecimal(t.ASSISTQTY) + t.UNASSISTQTY;
                    }
                    else
                    {
                        t.ASSISTQTY = G.Core.GConvert.ToDecimal(t.ASSISTQTY) + t.ONHANDQTY;
                    }
                    ((SM_BOMTEMPLogic)this.Logic).ExecuteUpdate(G.AppInfo.GGlobal.User, tempdata);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        SM_SALEORDER saleorder = null;
        public void SetPara(SM_SALEORDER order)
        {
            saleorder = order;
            this.TXT_ORDERID.SetValue(order.ORDERID);
            this.TXT_ORDERTYPE.SetValue(order.ORDERTYPENAME);
            this.TXT_CUSTNAME.SetValue(order.CUSTNAME);
            LoadGrid1(order.ORDERID);
        }
        private void LoadGrid1(string orderid)
        {
            Condition c = CK.K["ORDERID"].Eq(orderid) & CK.K["STATUS"].Eq("N") & CK.K["TYPEID"].Eq(1);
            List<SM_BOMTEMP> list = ((SM_BOMTEMPLogic)this.Logic).ExecuteSelect(G.AppInfo.GGlobal.User, c, OrderBy.Parse("ITEMCODE"), 0, 0);
            this.gGrid1.SetValue<SM_BOMTEMP>(list);
        }
        private void ShopSupply()
        {
            try
            {
                this.gGrid1.FinishEditing();
                List<SM_BOMTEMP> tempdata = (this.gGrid1.DataSource as BindingList<SM_BOMTEMP>).ToList<SM_BOMTEMP>();

                var updata = from temp in tempdata
                             where temp.ISSELECT == true
                             select temp;
                SM_SHOPSUPPLY shopsupply = new SM_SHOPSUPPLY();
                G.BLL.Sys.ND_ORGINAZITIONLogic orglogic = new G.BLL.Sys.ND_ORGINAZITIONLogic();
                ND_ORGINAZITION orgobj = orglogic.ExecuteSelect(CK.K["ID"].Eq(G.AppInfo.GGlobal.User.ORGID), OrderBy.Parse("ID"), 0, 0)[0];
                shopsupply.APPLYER = G.AppInfo.GGlobal.User.USERDM;
                shopsupply.APPLYERNAME = G.AppInfo.GGlobal.User.USERNAME;
                shopsupply.APPLYDATE = G.Core.GConvert.ToDateTime(System.Time.Now);
                shopsupply.WORKSHOP = orgobj.ORGDM;
                shopsupply.ORGNAME = orgobj.ORGNAME;
                bool nopass = true;
                foreach (SM_BOMTEMP t in updata)
                {
                    if (t.ONHANDQTY == 0 || t.UNASSISTQTY <= 0) { nopass = false; break; }
                    SM_SHOPSUPPLYDTL shopsupplydtl = new SM_SHOPSUPPLYDTL();
                    G.BLL.ERP.BaseData.DM_ITEMLogic itemlogic = new G.BLL.ERP.BaseData.DM_ITEMLogic();
                    DM_ITEM itemobj = itemlogic.ExecuteSelect(CK.K["ITEMCODE"].Eq(t.ITEMCODE), OrderBy.Parse("ITEMCODE"), 0, 0)[0];
                    shopsupplydtl.BOMTEMPID = t.Id;
                    shopsupplydtl.ITEMCODE = t.ITEMCODE;
                    shopsupplydtl.ITEMNAME = t.ITEMNAME;
                    shopsupplydtl.UNIT = t.INVUNIT;
                    shopsupplydtl.ATTRIBUTEA = t.ATTRIBUTEA;
                    shopsupplydtl.ATTRIBUTEB = t.ATTRIBUTEB;
                    shopsupplydtl.ATTRIBUTEBNAME = t.ATTRIBUTEBNAME;
                    shopsupplydtl.ATTRIBUTEC = t.ATTRIBUTEC;
                    shopsupplydtl.MEMO = t.MEMO;
                    shopsupplydtl.ATTRIBUTED = t.ATTRIBUTED;
                    shopsupplydtl.WRHSCODE = t.WRHSCODE;
                    shopsupplydtl.WRHSNAME = t.WRHSNAME;
                    shopsupplydtl.LOCCODE = t.LOCCODE;
                    shopsupplydtl.LOCNAME = t.LOCNAME;
                    shopsupplydtl.ISATTRIBUTEA = G.Core.GConvert.ToBool(itemobj.IsAttributeA);
                    shopsupplydtl.ISATTRIBUTEB = G.Core.GConvert.ToBool(itemobj.IsAttributeB);
                    shopsupplydtl.ISATTRIBUTEC = G.Core.GConvert.ToBool(itemobj.IsAttributeC);
                    if (t.UNASSISTQTY <= t.ONHANDQTY)
                    {
                        shopsupplydtl.ACTQTY = t.UNASSISTQTY;
                    }
                    else
                    {
                        shopsupplydtl.ACTQTY = t.ONHANDQTY;
                    }
                    shopsupply.SHOPSUPPLYDTL.Add(shopsupplydtl);
                }
                //弹出成品领料单，数据来自选择行
                G.Erp.Storage.SM_SHOPSUPPLYEDIT shopsupplyEdit = new G.Erp.Storage.SM_SHOPSUPPLYEDIT();
                shopsupplyEdit.CurEditStatus = EditorStatus.Modify;
                shopsupplyEdit.SetData(shopsupply);
                shopsupplyEdit.ShowDialog();
                //成品领料数量填入BOMTEMP
                foreach (SM_BOMTEMP t in updata)
                {
                    if (t.UNASSISTQTY <= t.ONHANDQTY)
                    {
                        t.STOCKQTY = G.Core.GConvert.ToDecimal(t.STOCKQTY) + t.UNASSISTQTY;
                    }
                    else
                    {
                        t.STOCKQTY = G.Core.GConvert.ToDecimal(t.STOCKQTY) + t.ONHANDQTY;
                    }
                    ((SM_BOMTEMPLogic)this.Logic).ExecuteUpdate(G.AppInfo.GGlobal.User, tempdata);
                }
                this.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
