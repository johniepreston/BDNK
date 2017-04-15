using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Leaf : INode
    {
        public Leaf(int value)
        {
            _value = value;
        }

        public void Add(INode node)
        {
            throw new NotImplementedException("Нельзя добавлять узел в листовой!");
        }

        public void Add(IList<INode> list)
        {
            throw new NotImplementedException("Нельзя добавлять узел в листовой!");
        }

        public void Print()
        {
            Console.Write(_value);
        }

        private int _value;

    }
}
