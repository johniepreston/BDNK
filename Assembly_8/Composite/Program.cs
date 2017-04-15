using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<INode> list1 = new List<INode>
            {
                new Leaf(1),
                new Leaf(2),
                new Leaf(3)
            };

            IList<INode> list2 = new List<INode>
            {
                new Leaf(5),
                new Leaf(6),
                new Leaf(7)
            };

            INode leaf = new Leaf(4);

            INode node = new Node();

            node.Add(list1);
            node.Add(leaf);
            node.Add(list2);

            node.Print();
            Console.ReadKey();
        }
    }
}
