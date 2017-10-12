using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace G.Core.Common
{
    public class DataPage
    {
        #region 直接在DataSet(数据集)中分页

        /// <summary>
        /// 直接在DataSet(数据集)中分页
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <param name="PageNum">每页显示条数</param>
        /// <param name="InPage">第几页</param>
        /// <returns></returns>
        public static DataSet DataSetPage(DataSet ds, int pageIndex, int pageSize)
        {
            DataSet vds = new DataSet();
            vds = ds.Clone();
            if (pageIndex < 0) pageIndex = 0;//如果小于1，取第一页
            if (pageIndex > Math.Ceiling((double)(ds.Tables[0].Rows.Count / pageSize))) { pageIndex = (int)Math.Ceiling((double)(ds.Tables[0].Rows.Count / pageSize)); }//页数大于总页数则取最后一页
            int fromIndex = pageSize * pageIndex;//开始行
            int toIndex = ds.Tables[0].Rows.Count < pageSize * (pageIndex + 1) ? ds.Tables[0].Rows.Count : pageSize * (pageIndex + 1); //结束行
            for (int i = fromIndex; i <= toIndex; i++)
            {
                if (i >= (ds.Tables[0].Rows.Count)) //到达这一行，退出
                    break;
                vds.Tables[0].ImportRow(ds.Tables[0].Rows[i]);
            }
            ds.Dispose();
            return vds;
        }
        #endregion
    }
}
