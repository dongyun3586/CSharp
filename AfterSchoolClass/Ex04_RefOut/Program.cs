﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 참조에 의한 매개변수 전달 ref, out */
namespace Ex04_RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref를 이용한 참조에 의한 매개변수 전달
            int x = 10, y = 20;
            Console.WriteLine($"초기 상태\n x = {x}, y = {y} \n");

            Swap(ref x, ref y);     // 메서드에 ref인자로 넘어가는 변수는 호출하는 측에서 반드시 값을 할당해야 한다.
            Console.WriteLine($"Swap() 함수 실행 후\n x = {x}, y = {y} \n");

            // out을 이용한 참조에 의한 매개변수 전달
            // 1. out으로 지정된 인자에 넘길 변수는 초기화되지 않아도 된다. 초기화해도 out인자를 받는 메서드에서 그값을 사용할 수 없음.
            // 2. out으로 지정된 인자를 받는 메서드는 반드시 변수에 값을 넣어서 반환해야 한다.
            int a = 20, b = 3;
            Console.WriteLine("초기 상태");
            Console.WriteLine($" a: {a}, b: {b} \n");

            Divide(a, b, out int quotient, out int remainder);
            Console.WriteLine("Divide()함수 실행 후");
            Console.WriteLine($" a/b: {quotient}, a%b: {remainder}  \n");
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }

        private static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }
}
