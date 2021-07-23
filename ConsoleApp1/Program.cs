﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //CasePractice(args);
            //CasePractice1(args);
            //Part1(args);
            //Part1_Test(args);
            //While_Practice(args);
            /*Class_Practice(args);

            Car car = new Car(); //
            car.SetInTime();
            car.SetOutTime();

            car.ShowInfo();*/

            //For_Prac(args);

            //Array arr = new Array();

            //arr.Array_Test();

            IFTest abc = new IFTest();

            //abc.If_Practice();
            //abc.If_Practice1();
            //abc.If_Prectice2();
            abc.If_Practice3();
            
        }

        static void CasePractice(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요 : ");
            int input = int.Parse(Console.ReadLine());

            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다");
                    break;
            }
        }

        static void CasePractice1(string[] agrs)
        {
            Console.WriteLine("이번달은 몇 월 인가요 ?");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄 입니다");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을 입니다");
                    break;

                default:
                    Console.WriteLine("대체 어떤 행성에 살고 있음 ?");
                    break;
                    

            }
        }


        static void Part1(string[] args)
        {
            //사용자에게 태어난 년도를 입력 받아 그 해의 띠를 출력하는 프로그램을 작성하시오
            //Hint = 입력 받은 년도를 12로 나눈 나머지를 사용한다. 나머지가 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11일 때에 각각 
            //원숭이, 닭, 개, 돼지, 쥐, 소, 범, 토끼, 용, 뱀, 말, 양띠이다

            Console.WriteLine("태어난 년도 입력 : ");
            int birth = int.Parse(Console.ReadLine());

            switch (birth % 12)
            {
                case 0:
                    Console.WriteLine("원숭이");
                    break;

                case 1:
                    Console.WriteLine("닭");
                    break;

                case 2:
                    Console.WriteLine("개");
                    break;

                case 3:
                    Console.WriteLine("돼지");
                    break;

                case 4:
                    Console.WriteLine("쥐");
                    break;

                case 5:
                    Console.WriteLine("소");
                    break;

                case 6:
                    Console.WriteLine("범");
                    break;

                case 7:
                    Console.WriteLine("토끼");
                    break;

                case 8:
                    Console.WriteLine("용");
                    break;

                case 9:
                    Console.WriteLine("뱀");
                    break;

                case 10:
                    Console.WriteLine("말");
                    break;

                case 11:
                    Console.WriteLine("양띠");
                    break;


            }
        }

        static void Part1_Test(string[] args)
        {
            //사용자에게 현재 월을 입력 받아 계절을 출력하는 프로그램을 작성하시오

            Console.WriteLine("현재 월을 입력하세요 : ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 11:
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울 입니다");
                    break;

                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("봄 입니다");
                    break;

                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("여름 입니다");
                    break;
            }
        }


        static void While_Practice(string[] agrs)
        {
            int i = 0;
            int[] intarray = { 52, 273, 32, 65, 103 };

            while (i < intarray.Length)
            {
                Console.WriteLine(i + "번째 출력 : " + intarray[i]);
                i++;
            }
        }

        static void Class_Practice(string[] args)
        {

        }

        class Car
        {
            int carNumber;
            DateTime inTime;
            DateTime outTime;

            public void SetInTime()
            {
                this.inTime = DateTime.Now;
            }

            public void SetOutTime()
            {
                this.outTime = DateTime.Now;
            }

            public void ShowInfo()
            {
                Console.WriteLine(inTime);
            }
        }

        static void For_Prac(string[] args)
        {
            for (int a = 0; a < 6; a++)
            {
                for (int b = 0; b < 6; b++)
                {
                    Console.WriteLine(a + "," + b);
                }
            }
        }

        

        
    }
}
