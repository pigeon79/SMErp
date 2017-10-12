using System;

namespace G.Data.Definition
{
    [Serializable]
    public abstract class DbObject : DbObjectBase
	{
		private int _id;

        [DbKey]
        public int Id
		{
			get { return _id; }
            set { _id = value; }
		}

        protected DbObject()
        {
        }
    }
}
