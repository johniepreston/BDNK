using Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteComponent
{
    public class Santa : Decorator
    {
        public Santa(IMan man)
            : base(man)
        {
        }

        public void Say()
        {
            base.Say();
            Console.Write("Я - Санта!\n");
        }

    }
}
