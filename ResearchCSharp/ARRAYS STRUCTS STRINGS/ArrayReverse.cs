using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.ARRAYS_STRUCTS_STRINGS
{
    class ArrayReverse
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Numero {0} =", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 4 ; i >=0; i--)
            {
                Console.WriteLine("{0} ", numbers[i]);
            }
        }
    }
}