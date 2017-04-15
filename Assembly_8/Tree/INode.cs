using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public interface INode
    {
        void Add(INode node);
        void Add(IList<INode> list);
        void Print();
    }


}
