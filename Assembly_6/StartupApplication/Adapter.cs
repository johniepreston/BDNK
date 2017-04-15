using Adaptee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target;

namespace StartupApplication
{
    public class Adapter : IBoat
    {
        private IAuto Auto;

        public Adapter(IAuto auto)
        {
            Auto = auto;
        }

        public Double Speed
        {
            get { return Auto.Speed; }
        }
    }
}
