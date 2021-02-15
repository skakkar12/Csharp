using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.Funtions
{
    class functionArraySum
    {
        public static int Sum(int[] example)
        {
            int total = 0;
            for (int i = 0; i < example.Length; i++)
            {
                total += example[i];
            }
            return total;
        }

        public static void Main(String[] args)
        {
            int[] samplearry = { 1, 3, 4, 5 };
            Console.Write("the sum of the array is ", Sum(samplearry));
        }   
    }
}