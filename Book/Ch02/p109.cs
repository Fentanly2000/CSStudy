using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p109
    {
        static void Main324(string[] args)
        {
            // int 자료형 숫자 생성
            int intNumber = 217483647;

            // int 자료형을 long 자료형으로 자동 변환
            long intToLong = intNumber;
            Console.WriteLine(intToLong);

            // int 자료형을 double 자료형으로 자동 변환
            double intTodouble = intNumber;
            Console.WriteLine(intTodouble);
        }
    }
}
