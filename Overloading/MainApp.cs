using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class MainApp  //오버로딩은 매개변수만 본다.컴파일러가 
    {
        static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int, int)...");
            return a + b;
        }
        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int, int, int)...");
            return a + b + c;
        }
        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling double Plus(double, double)...");
            return a + b;
        }
        static double Plus(int a, double b) //정수와 소수는 자동적으로 소수로 변환된다.
        {
            Console.WriteLine("Calling double Plus(int, double)...");
            return a + b;
        }
        static int Plus(double a, int b) //정수와 소수는 자동적으로 소수로 변환된다.
        {
            Console.WriteLine("Calling double Plus(int, double)...");
            return (int)(a + b); //int로 변환
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));
            Console.WriteLine(Plus(2.4, 1));
        }
    }
}
