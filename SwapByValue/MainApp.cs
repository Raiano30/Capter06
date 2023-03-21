using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapByValue
{
    class MainApp
    {
        public static void swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"X:{x}, y:{y}");

            swap(x, y);

            Console.WriteLine($"X:{x}, y:{y}"); // 매개변수는 데이터가 복사되는 것, 별개의 데이터 공간이다.
        }
    }
}
