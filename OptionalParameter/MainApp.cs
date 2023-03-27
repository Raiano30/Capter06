using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone = "") //string phone = "" 매개변수에서 초기화
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }


        static void Main(string[] args)
        {
            PrintProfile("중근");                  //선택적 인수 : 매개변수가 기본 값을 가지므로 인수를 생략 가능
            PrintProfile("관순", "010-123-1234");
            PrintProfile(name: "봉길");            //명명된 인수
            PrintProfile(name: "동주", phone:"010-789-7890");
        }
    }
}
