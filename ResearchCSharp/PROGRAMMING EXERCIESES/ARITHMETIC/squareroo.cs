using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.ARITHMETIC
{
    class squareroo
    {
        public static void Main(String[] args)
        {
            int square=0;

            Console.WriteLine("square root of the number is:");

            Console.WriteLine("enter the number");

            int number = int.Parse(Console.ReadLine());

            if (number<0)
            {
                Console.WriteLine("try again:");
            }
            else
            {
                square = number * number;
            }
            Console.WriteLine("the square root of the no is: {0}", square);



        }
    }
}
