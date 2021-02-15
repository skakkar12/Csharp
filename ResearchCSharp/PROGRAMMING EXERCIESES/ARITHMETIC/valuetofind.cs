using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.ARITHMETIC
{
    class valuetofind
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 34, 5, 6, 7, 8, 18, 87, 56 };
            Console.Write("array");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine("value to find ");

            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==value)
                {
                    Console.WriteLine("value found");
                }
            }
        }
    }
}