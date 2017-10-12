using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Data;

namespace G.BLL.WX
{
    public class WX_ConfigLogic
    {
        public void Insert(string json) {
            G.Entity.WX.WX_Config wconfig = new Entity.WX.WX_Config();
            wconfig = G.Core.JsonHelper.Json2Object<G.Entity.WX.WX_Config>(json);
            G.Data.DbEntry.Insert(wconfig);
        }
    }
}
