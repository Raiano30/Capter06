using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingParams
{
    class MainApp
    {
        static int Sum(params int[] args) //params가변개수의 인수
        {
            Console.Write("Summing... ");

            int sum = 0;
            for(int i = 0; i < args.Length; i++) //8보다 작을때까지 반복
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(args[i]); //0번째의 배열의 값을 출력, 1번째의 배열의 값을 출력
                                        //suming... 3, 4, 5, 6, 7, 8, 9, 10
                sum += args[i];  //3> 7> 12> 18> 25> 33> 42> 52
            }

            Console.WriteLine(); 
            return sum; //52의 값을 반환
        }
        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10); //8개의 배열이 인수로 넘어감

            Console.WriteLine($"Sum : {sum}"); // Sum : 52
        }
    }
}
