using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteFactory
{
    public class GlassPosudaFactory : IPosudaFactory
    {
        public IKnife CreateKnife()
        {
            return new GlassKnife();
        }

        public ISpoon CreateSpoon()
        {
            return new GlassSpoon();
        }
    }

}

