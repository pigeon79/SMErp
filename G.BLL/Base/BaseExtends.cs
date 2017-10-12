using G.Data;
using G.Data.Definition;
using G.Data.Model.QuerySyntax;
using G.BLL.Base;
using System;
using System.Data;
using G.Data.SqlEntry;

// ReSharper disable CheckNamespace
public static class BaseExtends
{
    public static ItemList<T> GetItemList<T>(this IPagedSelector<T> selector, long pageIndex) where T : class, IDbObject, new()
    {
        var result = new ItemList<T>
                         {
                             List = selector.GetCurrentPage(pageIndex),
                             Count = selector.GetResultCount(),
                             PageSize = selector.PageSize,
                             PageCount = selector.GetPageCount(),
                             PageIndex = pageIndex + 1
                         };
        return result;
    }

    public static ItemList<T> GetItemList<T>(this IGetPagedSelector<T> psd, ListStyle style, long? pageIndex) where T : class, IDbObject, new()
    {
        var ps
            = (style == ListStyle.Static) || (style == ListStyle.StaticLite) || (style == ListStyle.Hybird && pageIndex != null)
            ? psd.GetStaticPagedSelector()
            : psd.GetPagedSelector();

        var listPageCount = ps.GetPageCount();
        if (style == ListStyle.StaticLite)
        {
            listPageCount--;
        }
        if (pageIndex == null)
        {
            if (style == ListStyle.Static || style == ListStyle.StaticLite)
            {
                pageIndex = listPageCount;
            }
        }
        var list = ps.GetItemList((pageIndex ?? 1) - 1);
        if (style == ListStyle.Hybird && pageIndex == null)
        {
            list.PageIndex = 0;
        }
        if (style == ListStyle.StaticLite)
        {
            list.PageCount--;
        }
        return list;
    }

    public static DateTime GetServerDate()
    {
        DataSet ds = DbEntry.Provider.ExecuteDataset("select getdate() as now");
        return DateTime.Parse(ds.Tables[0].Rows[0]["now"].ToString());
    }
    public static String GetNewAutoNo(string type)
    {
        string newno = "";
        SqlStatement sql = new SqlStatement("Fu_CreateNewNo",
            new DataParameter("@dJlx", type, 20),
            new DataParameter("@ret", newno, typeof(string), ParameterDirection.Output, 50)
        );
        DbEntry.Provider.ExecuteNonQuery(sql);
        newno = G.Core.GConvert.ToString(sql.Parameters[1].Value);
        return newno;
    }
    public static string GetSysSetting(string key)
    {
        string value = "";
        SqlStatement sql = new SqlStatement("select fvalue from nd_syssetting where FKEY=@FKEY",
            new DataParameter("@FKEY", key)
        );
        DataSet ds = DbEntry.Provider.ExecuteDataset(sql);
        if (ds.Tables[0].Rows.Count > 0)
        {
            value = G.Core.GConvert.ToString(ds.Tables[0].Rows[0]["FVALUE"]);
        }
        return value;
    }
    public static bool SetSysSetting(string key, string value)
    {
        bool isSet = false;
        try
        {
            SqlStatement sql = new SqlStatement("update nd_syssetting set FVALUE=@FVALUE where FKEY=@FKEY",
                new DataParameter("@FKEY", key), new DataParameter("@FVALUE", value)
            );
            DbEntry.Provider.ExecuteNonQuery(sql);
            isSet = true;
        }
        catch (Exception e)
        {
            throw e;
        }

        return isSet;
    }
}
