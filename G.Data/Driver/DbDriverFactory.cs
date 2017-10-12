using System;
using G.Core;
using G.Core.Setting;
using G.Core.Text;
using G.Data.Common;
using G.Data.Dialect;

namespace G.Data.Driver
{
    public class DbDriverFactory : FlyweightBase<string, DbDriver>
    {
        public static readonly DbDriverFactory Instance = new DbDriverFactory();

        protected override DbDriver GetInst(string tk)
        {
            var name = tk.IsNullOrEmpty() ? DataSettings.DefaultContext : tk;
            return base.GetInst(name);
        }

        protected override DbDriver CreateInst(string t)
        {
            return GetDriver(t);
        }

        private static DbDriver GetDriver(string prefix)
        {
            var name = prefix;
            if (prefix != "") { prefix += "."; }
            string pd = prefix + "DataBase";
            string ds = ConfigHelper.GSettings.GetValue(pd);
            if (ds == "")
            {
                throw new SettingException("DataBase must be set as a valid value. Current get is : " + pd);
            }
            string[] ss = StringHelper.Split(ds, ':', 2);
            ds = ss[0].Trim();
            if (ds[0] == '@')
            {
                ds = "G.Data.Dialect." + ds.Substring(1) + ", G.Data";
            }
            var d = (DbDialect)ClassHelper.CreateInstance(ds);
            string cs = d.GetConnectionString(ss[1].Trim());
            string pf = ConfigHelper.GSettings.GetValue(prefix + "DbProviderFactory");
            string dcn = ConfigHelper.GSettings.GetValue(prefix + "DbDriver");
            string act = ConfigHelper.GSettings.GetValue(prefix + "AutoCreateTable");
            string auto = ConfigHelper.GSettings.GetValue(prefix + "AutoScheme");
            return CreateDbDriver(d, name, dcn, cs, pf, act, auto);
        }

        private static DbDriver CreateDbDriver(DbDialect dialectClass, string name, string driverClassName, 
            string connectionString, string dbProviderFactoryName, string act, string auto)
        {
            var autoScheme = AutoScheme.None;
            if(auto.IsNullOrEmpty())
            {
                if(!string.IsNullOrEmpty(act))
                {
                    if(bool.Parse(act))
                    {
                        autoScheme = AutoScheme.CreateTable;
                    }
                }
            }
            else
            {
                autoScheme = (AutoScheme)Enum.Parse(typeof(AutoScheme), auto);
            }
            CheckProperty(dialectClass, connectionString);
            if (driverClassName == "")
            {
                return dialectClass.CreateDbDriver(name, connectionString, dbProviderFactoryName, autoScheme);
            }
            return (DbDriver)ClassHelper.CreateInstance(driverClassName,
                dialectClass, name, connectionString, dbProviderFactoryName, autoScheme);
        }

        // ReSharper disable UnusedParameter.Local
        private static void CheckProperty(DbDialect dialectClass, string connectionString)
        // ReSharper restore UnusedParameter.Local
        {
            if (dialectClass == null || connectionString == "")
            {
                throw new SettingException("DialectClass or ConnectionString not defined in the App.config file.");
            }
        }
    }
}
