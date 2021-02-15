using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.OPERATORS
{
    class SomeArithmeticOperators
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter first number :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("a+b :{}", a + b);
            Console.WriteLine("a-b :{}", a - b);
            Console.WriteLine("a*b :{}", a * b);
            Console.WriteLine("a/b :{}", a / b);
        }
    }
}
