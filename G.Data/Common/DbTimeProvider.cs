using System;
using G.Core;
using G.Data.SqlEntry;

namespace G.Data.Common
{
    public class DbTimeProvider
    {
        private readonly DataProvider _context;
        private DateTime _lastCheckTime;
        private TimeSpan _timeDiff;

        public DbTimeProvider(DataProvider context)
        {
            _context = context;
        }

        public DateTime Now
        {
            get
            {
                var now = Util.Now;
                if((now - _lastCheckTime).TotalMinutes > DataSettings.DbTimeCheckMinutes)
                {
                    _lastCheckTime = now;
                    var dbNow = _context.GetDatabaseTime();
                    _timeDiff = now - dbNow;
                }
                return now - _timeDiff;
            }
        }
    }
}
