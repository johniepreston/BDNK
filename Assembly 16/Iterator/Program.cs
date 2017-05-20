using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> list = new List<string>() { "Катя", "Маша", "Паша", "Игорь" };
            IAgregator<string> myList = new MyList<string>(list);
            IIterator<string> iterator = new MyListIterator<string>(myList);

            for (IIterator<string> i = iterator; !i.IsDone; i.Next())
            {
                Console.WriteLine(i.CurrentItem);
            }

            Console.ReadKey();
        }
    }
}
