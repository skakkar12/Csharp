using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.ARITHMETIC
{
    class ForloopAdd
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("enter the for loop values number :");
            int number = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = 0; i < number; i++)
            {
                total += i;
            }

            Console.WriteLine("The sum is : {0}", total);
        }
    }
}