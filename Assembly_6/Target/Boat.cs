using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target
{
    class Boat : IBoat
    {
        public Boat()
        {
            Speed = 15;
        }
        public Double Speed { get; set; }

    }
}
