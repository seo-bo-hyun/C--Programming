using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array
    {
        

        public void Array_Test()
        {
            // 1. 다음 1차원 배열의 합과 평균을 구하세요
            // 조건1) 배열 초기값 -> 20, 34, 22, 14, 36, 23, 67

            int[] arr = { 20, 34, 22, 14, 36, 23, 67 };
            int hap = 0;
            int avg = 0;

            for (int i = 0; i <arr.Length; i++)
            {
                hap += arr[i];
                avg = arr[i] / arr.Length;
            }

            Console.WriteLine("총합 : " + hap);
            Console.WriteLine();
            Console.WriteLine("평균 : " + avg);


        }


        public void Array_Test1()
        {
            // 2. 1 ~ 100까지의 수를 1차원 배열에 저장
            // 조건1) 저장된 배열에서 5의 배수만 출력하세요
            // 조건2) 배열의 위치가 90번째 일때 출력을 중지함
        }




    }
}
