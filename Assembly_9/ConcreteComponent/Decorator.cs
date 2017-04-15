using Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteComponent
{
    public class Decorator
    {
        public Decorator(IMan man)
        {
            _man = man;
        }

        public void Say()
        {
            _man.Say();
        }

        private IMan _man;

    }
}
