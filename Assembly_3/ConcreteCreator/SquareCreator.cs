using Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteCreator
{
    public class SquareCreator : ICreator
    {
        public IFigure FactoryMethod()
        {
            return new Square();
        }

    }
}
