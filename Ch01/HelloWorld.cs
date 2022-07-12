using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 날짜: 2022년 7월 12일
// 이름: 김철학
// 내용: C# 개발환경 설정, Hello world 출력 교재 p44

namespace Ch01
{
    internal class HelloWorld 
    {
        static void Main(string[] args) //svm
        {
            // 기본출력
            Console.WriteLine("Hello World!"); //cw tap2
            Console.WriteLine("Hello C#!");

            // 서식출력
            Console.Write("Hello\t"); // 복사 ctrld t: tap n: new line
            Console.Write("Korea\n");
            // 실행: F5

            // 포맷출력
            Console.WriteLine("{0}, {1}", "Hello", "Busan");
        }
    }
}
