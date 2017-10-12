using System.Collections.Specialized;

namespace G.Core.Setting
{
	public class ConfigHelper : ConfigHelperBase
	{
        public static readonly ConfigHelper AppSettings = new ConfigHelper("appSettings");
        public static readonly ConfigHelper GSettings = new ConfigHelper("G.Settings");

        internal ConfigHelper()
        {
            AppSettings._nvc = new ConfigHelper("appSettings")._nvc;
            GSettings._nvc = new ConfigHelper("G.Settings")._nvc;
        }

        private NameValueCollection _nvc;

		public ConfigHelper(string sectionName)
		{
            NameValueCollection _curnvc = ConfigReaderProxy.Instance.GetSection(sectionName);
            string curcontent = System.Configuration.ConfigurationManager.AppSettings["CurContext"];
            _nvc = new NameValueCollection();
            foreach (string s in _curnvc.AllKeys) {
                if (s == "DefaultContext" && !string.IsNullOrEmpty(curcontent)) {
                    _nvc.Add("DefaultContext", curcontent);
                }
                else {
                    _nvc.Add(s, _curnvc[s]);
                }
            }
        }

		protected override string GetString(string key)
		{
			return _nvc[key];
		}
	}
}
