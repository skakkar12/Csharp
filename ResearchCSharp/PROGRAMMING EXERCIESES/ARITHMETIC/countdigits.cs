using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.ARITHMETIC
{
    class countdigits
    {
        public static void Main(string[] args)
        {
            Console.Write("enter the number:");
            int number = int.Parse(Console.ReadLine());


            Console.Write("the no of digits are: ");
            int length = number.ToString().Length;

            Console.Write("the count of the characters are : {0}", length);


        }
    }
}