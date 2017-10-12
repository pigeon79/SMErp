using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G.Core.Common
{
    public enum ReportType
    {
        entity,
        sql,
        proc,
    }
    /// <summary>
    /// 分页类型 客户端分页 服务器端分页
    /// </summary>
    public enum CutPageType { 
        customer,
        server
    }
}
