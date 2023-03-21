using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapByRef
{
    class MainApp
    {
        static void Swap(ref int a, ref int b) //ref 매개변수는 주소값이 넘어간다.
        {
            int temp = b; //b의 값이 넘어간다.
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"x:{x}, y:{y}");

            Swap(ref x, ref y);//ref 참조에 의한 전달

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}
