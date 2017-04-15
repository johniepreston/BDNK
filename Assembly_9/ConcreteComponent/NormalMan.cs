using Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteComponent
{
    public class NormalMan : IMan
    {
        public void Say()
        {
            Console.Write("Говорит: ");
        }

    }
}
