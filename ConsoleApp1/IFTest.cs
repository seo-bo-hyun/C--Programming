using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IFTest
    {
        public void If_Practice()
        {
            // 1. 1개의 숫자를 입력 받아서 짝수, 홀수인지 판단하는 프로그램
            // (나머지 연산을 사용하면 쉬움)
            // ----------------------
            // 홀짝 판단 프로그램 v1.0
            // ----------------------
            // 숫자 입력 -> 10
            // 출력은 아래중에 1개를 출력
            // 1) 입력한 숫자는 홀수 입니다
            // 2) 입력한 숫자는 짝수 입니다

            Console.WriteLine("======================");
            Console.WriteLine("홀짝 판단 프로그램 v1.0");
            Console.WriteLine("======================");

            Console.WriteLine("숫자를 입력하세요");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("입력한 숫자는 짝수 입니다");
            }
            else
            {
                Console.WriteLine("입력한 숫자는 홀수 입니다");
            }



        }

        public void If_Practice1()
        {
            // 2. 2개의 숫자를 입력 받아서 크다, 작다를 비교하는 프로그램
            // ----------------------
            // 대소 비교 프로그램 v1.0
            // ----------------------
            // 1. num1 입력 -> 10
            // 2. num2 입력 -> 5

            // 출력은 아래의 3개중에 하나를 출력 바람
            // 1) num1이 num2 보다 크다
            // 2) num2가 num1 보다 크다
            // 3) num1과 num2는 같다

            Console.WriteLine("======================");
            Console.WriteLine("대소 비교 프로그램 v1.0");
            Console.WriteLine("======================");

            Console.WriteLine("숫자 1 입력 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자 2 입력 : ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("num1이 num2 보다 크다");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("num2가 num1 보다 크다");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("num1과 num2는 같다");
            }

        }

        public void If_Prectice2()
        {
            // 3. 2개의 숫자를 입력 받아서 +, -, x, / 연산자를 사용하는 간단한 계산기
            // --------------------
            // 간단한 계산기 프로그램
            // --------------------

            // 1. num1 입력 -> 10
            // 2. num2 입력 -> 5
            // 3. 연산자 입력(+, -, *, /) -> +

            

            Console.WriteLine("=====================");
            Console.WriteLine("간단한 계산기 프로그램");
            Console.WriteLine("=====================");

            Console.WriteLine("숫자 1 입력 : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자 2 입력 : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자 입력 : +, -, x, /");
            int c = char.Parse(Console.ReadLine());

            if (c == '+')
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            }
            else if (c == '-')
            {
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            }
            else if (c == '*')
            {
                Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
            }
            else if (c == '/')
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            }



        }

        public void If_Practice3()
        {
            // 국어, 영어, 수학 점수를 입력 받아서 합과 평균을 구하여 학점을 출력하는 프로그램
            // ----------------------
            // 학점 관리 프로그램 v1.0
            // ----------------------

            // 100 ~ 90 = A 학점
            // 89 ~ 80 = B 학점
            // 79 ~ 70 = C 학점
            // 69 ~ 60 = D 학점
            // 59 ~ 50 = E 학점
            // 49 ~ 0 = F 학점

            // 입력 형식
            // 1. 국어 점수 입력 -> 100
            // 2. 영어 점수 입력 -> 80
            // 3. 수학 점수 입력 -> 90

            // 출력 형식
            // 총점 270
            // 평균 90
            // 학점은 A 입니다 

            Console.WriteLine("======================");
            Console.WriteLine("학점 관리 프로그램 v1.0");
            Console.WriteLine("======================");

            Console.WriteLine("국어 점수 입력 : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("영어 점수 입력 : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("수학 점수 입력 : ");
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;
            int avg = (a + b + c) / 3;

            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + avg);
            

            if (avg == 100 && avg >= 90)
            {
                
                Console.WriteLine("학점 : A");
            }
            else if (avg <= 89 && avg >= 80)
            {
                
                Console.WriteLine("학점 : B");
            }
            else if (avg <= 79 && avg >= 70)
            {
                
                Console.WriteLine("학점 : C");
            }
            else if (avg <= 69 && avg > 60)
            {
                
                Console.WriteLine("학점 : D");
            }
            else if (avg <= 59 && avg > 50)
            {
                
                Console.WriteLine("학점 : E");
            }
            else if (avg <= 49 && avg > 40)
            {
                Console.WriteLine("학점 : F");
            }
            else
            {
                Console.WriteLine("학사경고");
            }

            


        }
    }
}
