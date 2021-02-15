using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.Funtions
{
    class Functiondouble
    {
        public static int Double(int number)
        {
            return number * 2;
        }

        public static void Main(string[] args)
        {
            Console.Write("enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("double of  {0} is {1} ", number, Double(number));
        }
    }
}