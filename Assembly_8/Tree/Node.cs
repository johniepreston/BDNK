using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Node : INode
    {
        public Node()
        {
            _nodeList = new List<INode>();
        }

        public void Add(INode node)
        {
            _nodeList.Add(node);
        }

        public void Add(IList<INode> list)
        {
            foreach (INode node in list)
                _nodeList.Add(node);
        }

        public void Print()
        {
            foreach (INode node in _nodeList)
                node.Print();
        }

        private IList<INode> _nodeList;

    }
}
