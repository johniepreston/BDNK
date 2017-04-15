using Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class LowManager : IEmployee
    {
        public LowManager(IMan man)
        {
            _man = man;
        }

        public void Make()
        {
            Console.WriteLine("LowManager: ");
            _man.Make();
        }

        private IMan _man;

    }
}
