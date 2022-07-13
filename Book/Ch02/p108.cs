using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p108
    {
        static void Main423(string[] args)
        {
            // long 자료형을 int 자료형으로 변환 
            long longNumber = 214783647L + 214783647L;
            int longToint = (int)longNumber;
            Console.WriteLine(longToint);

            // double 자료형을 int 자료형으로 변환 
            double doubleNumber = 52.27310332;
            int doubleToint = (int)doubleNumber;
            Console.WriteLine(doubleToint);
        }
    }
}
