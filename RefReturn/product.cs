using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefReturn
{
    class product //자바의 겟셋방식 일부를 따온 것 //mainapp 클래스와 같은 스크립트안에 있으니 public class라고 쓰지 않아도 된다. 외부에서 접근할 때는 public 명시해야 한다.
    {
        private int price = 100; //private 외부에서는 접근 불가//멤버변수, 전역변수, 필드

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice() //void 반환 값 없이 기능만 있는 메소드
        {
            Console.WriteLine($"Price : {price}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            product carrot = new product(); //클래스를 carrot 이름의 변수로 객체화 
            ref int ref_local_price = ref carrot.GetPrice(); //참조변수에 클래스의 메서드 주소값 담는다
            int normal_local_price = carrot.GetPrice();      //일반변수에 클래스 메서드를 담는다. 복사된다.

            carrot.PrintPrice();                                            //100
            Console.WriteLine($"Ref Local Price :{ref_local_price}");       //참조변수 100
            Console.WriteLine($"Normal_local_price :{normal_local_price}"); //일반변수 100

            ref_local_price = 200; //주소값으로 넘어가서 메소드 값이 200으로 바뀐다.

            carrot.PrintPrice();                                            //200
            Console.WriteLine($"Ref_local_price {ref_local_price}");        //참조변수 200
            Console.WriteLine($"Normal_local_price {normal_local_price}");  //일반변수 100
        }
    }
}
