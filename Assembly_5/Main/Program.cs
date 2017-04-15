using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Heart heart = Heart.Instance();
            heart.Frequence = 120;

            Heart heart2 = Heart.Instance();

            if (heart.Frequence == heart2.Frequence)
                Console.WriteLine(heart2.Frequence + "=)");
            else
                Console.WriteLine(heart2.Frequence + "=(");

            Console.Read();

        }
    }
}
