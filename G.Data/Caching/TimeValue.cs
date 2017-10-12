using System;
using G.Data.Common;
using G.Core;

namespace G.Data.Caching
{
    public class TimeValue
    {
        public DateTime ExpiredOn;
        public object Value;

        public TimeValue(DateTime expiredOn, object value)
        {
            this.ExpiredOn = expiredOn;
            this.Value = value;
        }

        public static DateTime GetExpiredOn()
        {
            return Util.Now.AddMinutes(DataSettings.CacheMinutes);
        }

        public static TimeValue CreateTimeValue(object value)
        {
            return new TimeValue(GetExpiredOn(), value);
        }
    }
}
