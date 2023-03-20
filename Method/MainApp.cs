using System;


namespace Method
{
    class Calculator
    {
        public int Plus(int a, int b) //매개 변수가 인수를 받았다. int3, int4
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class MainApp
    {
        public static void Main() //Main이 먼저 발동
        {
            Calculator cal= new Calculator(); //설계도 가지고 생성해 a 변수에 calculator 형식만 넣을 수 있다. 

            int result = cal.Plus(3, 4); //Calculator. 클래스의 plus메서드에 인수를 보내서 호출
            Console.WriteLine(result);  //7

            result = cal.Minus(5, 2);
            Console.WriteLine(result);  //3
        }
    }
}
