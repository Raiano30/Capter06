using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class MainApp
    {
        static void Main(string[] args)
        {

            //while문 별 증가
            int i = 0;
            while (i < 5)  //0이 5보다 작을때까지 반복 0,1,2,3,4(++안하면 무한반복)
            {
                int j = 0;
                while (j <= i)  //j가 i이하인만큼 반복 (++안하면 무한반복)
                {
                    Console.Write("*");
                    j++; //0,1,2,3,4 (i가 4까지가 max)
                }
                Console.WriteLine();
                ++i; //행넘아가서 다시 1의 값으로 반복
            }
            //*
            //**
            //***
            //****
            //*****

            //while문 별 감소



            //*****
            //****
            //***
            //**
            //*














        }
    }
}
