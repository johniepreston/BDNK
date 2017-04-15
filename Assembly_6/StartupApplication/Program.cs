using Adaptee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target;

namespace StartupApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IAuto auto = new Auto();
            IBoat boat = new Adapter(auto);
            if (boat.Speed == 100.0)
                Console.WriteLine("Работает");
            else
                Console.WriteLine("Не работает");

            Console.ReadKey();
        }
    }
}
