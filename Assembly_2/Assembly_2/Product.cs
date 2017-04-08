using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Product
    {
        private readonly List<string> wheels = new List<string>();

        public void Add(string wheel)
        {
            wheels.Add(wheel);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Wheels -------");
            foreach (string wheel in wheels)
                Console.WriteLine(wheel);
        }

    }
}
