using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.ARITHMETIC
{
    class largestvalue
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 47, 8, 10, 56, 89, 45, 70 };

            Console.WriteLine("The array values are :");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }



            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>arr[i+1])
                {
                    temp = arr[i];
                }
                else
                {
                    temp = arr[i + 1];
                }
            }

        }
    }
}