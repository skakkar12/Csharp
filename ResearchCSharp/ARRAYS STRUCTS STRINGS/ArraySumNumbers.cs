using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.ARRAYS_STRUCTS_STRINGS
{
    class ArraySumNumbers
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[1000];
            int total = 0;
            int counter=0;
            string enteredno;
            Console.WriteLine("enter a number :");
            enteredno = Console.ReadLine();

            do
            {
                if (enteredno!="end")
                {
                    Console.WriteLine("enter a number");
                    numbers[counter] = Convert.ToInt32(Console.ReadLine());
                    total += numbers[counter];

                    Console.WriteLine("Sum: {0}", total);
                    total++;
                }
                
            } while (enteredno!="end");
        }
    }
}