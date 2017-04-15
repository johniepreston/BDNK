using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptee
{
    public class Auto : IAuto
    {
        public Auto()
        {
            Speed = 100;
        }

        public Double Speed { get; set; }
    }
}
