using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IAgregator<T>
    {
        T Get(Int32 index);
        Int32 Count { get; }
    }
}
