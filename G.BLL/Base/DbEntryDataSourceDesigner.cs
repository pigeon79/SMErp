using System;

namespace G.BLL.Base
{
    public class DbEntryDataSourceDesigner 
    {
        public override bool CanConfigure
        {
            get { return false; }
        }

        public override bool CanRefreshSchema
        {
            get { return false; }
        }

        public override void Configure()
        {
            throw new NotImplementedException();
        }
        
        public override string[] GetViewNames()
        {
            return new[] { "MainView" };
        }

        public override void RefreshSchema(bool preferSilent)
        {
            throw new NotImplementedException();
        }
    }
}
