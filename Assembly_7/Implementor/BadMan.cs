﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementor
{
    public class BadMan : IMan
    {
        public void Make()
        {
            Console.WriteLine("Нет времени!\n");
        }

    }
}
