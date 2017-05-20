using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class MyList<T> : IAgregator<T>
    {
        private IList<T> _list;
        public MyList(IList<T> list)
        {
            _list = list ?? throw new ArgumentNullException("Argument list is null");
        }
        public int Count
        {
            get { return _list.Count; }
        }

        public T Get(int index)
        {
            return _list[index];
        }
    }
}
