using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteFactory
{
    public class MetalPosudaFactory : IPosudaFactory
    {
        public IKnife CreateKnife()
        {
            return new MetalKnife();
        }

        public ISpoon CreateSpoon()
        {
            return new MetalSpoon();
        }

    }
}
