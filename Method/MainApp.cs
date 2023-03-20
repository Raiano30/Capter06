using System;


namespace Method
{
    class Calculator
    {
        public static int Plus(int a, int b) //매개 변수가 인수를 받았다. int3, int4
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class MainApp
    {
        public static void Main() //Main이 먼저 발동
        {
            //static이 아닌 클래스의 메서드는 변수에 담아서 가져와야 한다.//인스턴스화(청사진으로 오브젝트를 만드는 것)
            //Calculator cal= new Calculator(); //청사진을 가지고 새로 생성해 cal 변수에 calculator 형식만 넣을 수 있다. 
            int result = Calculator.Plus(3, 4); //Calculator. 클래스의 plus메서드에 인수를 보내서 호출
            Console.WriteLine(result);  //7

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);  //3
        }
    }
}
