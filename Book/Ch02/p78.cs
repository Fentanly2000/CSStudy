﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p78
    {
        static void Main17(string[] args)
        {


            Console.WriteLine(DateTime.Now.Hour < 12 || 18 < DateTime.Now.Hour);
            Console.WriteLine(12 < DateTime.Now.Hour && DateTime.Now.Hour < 18);

        }
    }
}
