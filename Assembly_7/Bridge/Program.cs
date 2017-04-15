using Abstraction;
using Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMan badMan = new BadMan();
            IMan goodMan = new GoodMan();

            IEmployee badLowManager = new LowManager(badMan);
            IEmployee goodLowManager = new LowManager(goodMan);
            IEmployee badHighManager = new HighManager(badMan);
            IEmployee goodHighManager = new HighManager(goodMan);

            badLowManager.Make();
            goodLowManager.Make();
            badHighManager.Make();
            goodHighManager.Make();

            Console.ReadKey();
        }
    }
}
