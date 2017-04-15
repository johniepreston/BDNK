using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Heart
    {
        public static Heart Instance()
        {
            return GetSingletonData();
        }

        protected static Heart GetSingletonData()
        {
            if (_instance == null)
            {
                _instance = new Heart();
            }

            return _instance;
        }

        protected Heart()
        {
        }

        public double Frequence { get; set; }

        private static Heart _instance;
    }

}
