using Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class HighManager : IEmployee
    {
        public HighManager(IMan man)
        {
            _man = man;
        }

        public void Make()
        {
            Console.WriteLine("HighManager: ");
            _man.Make();
        }

        private IMan _man;

    }
}
