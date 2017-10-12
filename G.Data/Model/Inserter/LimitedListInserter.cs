using System.Collections;
using G.Data.Common;

namespace G.Data.Model.Inserter
{
    public class LimitedListInserter : IProcessor
    {
		private readonly IList _list;
        private int _count;

        public LimitedListInserter(IList list)
		{
			this._list = list;
            _count = 0;
		}

		public bool Process(object obj)
		{
			_list.Add( obj );
            _count++;
            return (_count < DataSettings.MaxRecords);
		}
    }
}
