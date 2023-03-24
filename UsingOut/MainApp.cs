using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOut
{
    class MainApp  //출력전용 매개변수 //자료구조형 배열을 넘겨받는다.
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;    //몫
            remainder = a % b;   //나머지
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            //int c; 초기화하지 않은 지역 변수를 메소드의 OUT 매개변수로 넘길 수 있다.
            //int d;
            Divide(a, b, out int c, out int d); //out키워드는 주고값을 넘긴다. 

            Console.WriteLine($"a:{a}, b:{b}:, a/b:{c}, a%b:{d}"); 
        }
    }
}
