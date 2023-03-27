using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunction
{
    class MainApp
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();       //문자열을 char[] 문자배열로 변환 // var타입형: 컴파일러가 데이터 타입을 부여

            for (int i = 0; i < arr.Length; i++) //char 배열 길이만큼 반복 
            {
                arr[i] = ToLowerChar(i);
            }
            char ToLowerChar(int i)             //반환 값이 char 캐릭터
            {
                if (arr[i] < 65 || arr[i] > 90) //A~Z의 ASCII 아스키코드 값 : 65~90 // 또는
                    return arr[i];
                else  // a~z의 ASCII값 :97~122
                    return (char)(arr[i] + 32); //대문자를 소문자로 변환해주는 것 H -> h 
            }
            return new string(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
            Console.WriteLine(ToLowerString("This is C#."));
        }
    }
}
