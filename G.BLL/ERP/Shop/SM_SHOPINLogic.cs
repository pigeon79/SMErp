using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.BLL.Base;
using G.BLL.ERP.BaseData;
using G.Data;
using G.Data.Model.Linq;
using G.Data.Model.QuerySyntax;
using G.Entity.ERP;
using G.Entity.SysEnt;

namespace G.BLL.ERP.Shop
{
    public class SM_SHOPINLogic : BaseBLL<SM_SHOPIN>
    {
        public override int ExecuteDelete(ND_USER user, SM_SHOPIN obj)
        {
            if (obj.STATUS == "N")
            {
                return base.ExecuteDelete(user, obj);
            }
            else { throw new Exception("新增单据才能删除"); }
        }
        public void Audit(ND_USER user, SM_SHOPIN obj)
        {
            if (obj.STATUS == "N")
            {
                DbEntry.UsingTransaction(delegate
                {
                    string csql = string.Format("exec SMProc_ApproveShopIn {0},'{1}' ", obj.Id, user.USERDM);
                    DbEntry.Provider.ExecuteNonQuery(csql);
                });
            }
            else { throw new Exception("订单已审核！"); }
        }
        public override int ExecuteUpdate(ND_USER user, SM_SHOPIN obj)
        {
            this.ValidShopInData(obj);
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.SHOPINID = BaseExtends.GetNewAutoNo("WI");
                obj.OPERATOR = user.USERDM;
                UpdateShoporder(user, obj);
            }
            base.ExecuteUpdate(user, obj);
            return obj.Id;
        }
        private void UpdateShoporder(ND_USER user,SM_SHOPIN shopin)
        {
            if (shopin.SHOPORDERID != "")
            {
                G.BLL.ERP.Shop.SM_SHOPORDERLogic shoporderlogic = new G.BLL.ERP.Shop.SM_SHOPORDERLogic();
                List<SM_SHOPORDER> shoporderlist = shoporderlogic.ExecuteSelect(CK.K["SHOPORDID"].Eq(shopin.SHOPORDERID), OrderBy.Parse("SHOPORDID"), 0, 0);
                if (shoporderlist.Count > 0)
                {
                    SM_SHOPORDER shoporderobj = shoporderlist[0];
                    if (shoporderobj.FINQTY == null)
                    {
                        shoporderobj.FINQTY = 0;
                    }
                    shoporderobj.FINQTY += shopin.INQTY;
                    shoporderlogic.ExecuteUpdate(user, shoporderobj);
                }
            }
        }
        public override bool SaveBefore(ref SM_SHOPIN obj)
        {
            DM_ITEMLogic itemlogic = new DM_ITEMLogic();
            DM_ITEM item=itemlogic.GetItemByCode(obj.ITEMCODE);
            if (item != null)
            {
                obj.ISATTRIBUTEA = G.Core.GConvert.ToBool(item.IsAttributeA);
                obj.ISATTRIBUTEB = G.Core.GConvert.ToBool(item.IsAttributeB);
                obj.ISATTRIBUTEC = G.Core.GConvert.ToBool(item.IsAttributeC);
            }
            if (obj.ISATTRIBUTEA == false)
            {
                obj.ATTRIBUTEA = "";
            }
            if (obj.ISATTRIBUTEB == false)
            {
                obj.ATTRIBUTEB = "";
                obj.ATTRIBUTEBNAME = "";
            }
            if (obj.ISATTRIBUTEC == false)
            {
                obj.ATTRIBUTEC = 0;
            }
            return true;
        }

        private void ValidShopInData(SM_SHOPIN obj)
        {
            DM_ITEMLogic itemlogic = new DM_ITEMLogic();
            DM_ITEM item = itemlogic.GetItemByCode(obj.ITEMCODE);
            if (G.Core.GConvert.ToString(obj.ITEMCODE) == "")
            {
                throw new Exception("没有物品，不能保存！");
            }
            if (G.Core.GConvert.ToBool(item.IsAttributeA) == true && G.Core.GConvert.ToString(obj.ATTRIBUTEA) == "")
            {
                throw new Exception("没有色号，不能保存！");
            }
            if (G.Core.GConvert.ToString(obj.WRHSCODE) == "")
            {
                throw new Exception("没有仓库，不能保存！");
            }
            if (G.Core.GConvert.ToString(obj.LOCCODE) == "")
            {
                throw new Exception("没有库位，不能保存！");
            }
            if (G.Core.GConvert.ToDecimal(obj.INQTY) == 0)
            {
                throw new Exception("数量为0，不能保存！");
            }
        }
    }
}
