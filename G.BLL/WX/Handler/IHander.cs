using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G.BLL.WX.Handler
{
    public interface IHandler
    {
        /// <summary>
        /// 处理请求
        /// </summary>
        /// <returns></returns>
        string HandleRequest();
    }
}
