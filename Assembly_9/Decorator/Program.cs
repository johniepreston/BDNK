using Component;
using ConcreteComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMan man = new NormalMan();
            Santa santa = new Santa(man);
            Grinch grinch = new Grinch(man);
            santa.Say();
            grinch.Say();

            Console.ReadKey();

        }
    }
}
