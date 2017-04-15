using ConcretePrototype;
using Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(String[] args)
        {
            Text a = new Text("aaaaaa");
            IPrototype b = a.Clone();
            Text c;
            if ((b as Text) != null)
                c = (Text)b;
        }

    }
}
