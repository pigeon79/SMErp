using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace G.Interface.BLL
{
    public interface ISearch
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SearchCondition">默认条件</param>
        /// <param name="SearchText">查询字符</param>
        /// <param name="Fields"></param>
        /// <param name="ValueField">设置默认值时，值字段名=查询字符</param>
        /// <returns></returns>
        DataTable SearchValue(G.Data.Condition SearchCondition, string SearchText, string Fields, string ValueField);
    }
}
