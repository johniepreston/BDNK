using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class MyListIterator<T> : IIterator<T>
    {
        public MyListIterator(IAgregator<T> list)
        {
            _list = list ?? throw new ArgumentNullException("Argument list is null");
        }
        public bool IsDone
        {
            get
            {
                if (_list.Count <= _current)
                    return true;
                return false;
            }
        }

        public T CurrentItem
        {
            get { return _list.Get(_current); }
        }

        public T First()
        {
            return _list.Get(0);
        }

        public T Next()
        {
            _current++;

            if (!IsDone)
                return _list.Get(_current);

            return default(T);
        }
        private IAgregator<T> _list;
        private Int32 _current = 0;
    }
}
