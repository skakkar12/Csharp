using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text;
using System.Data;
using System.Data.Sql;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.ARITHMETIC
{
    class findArray
    {
        public static void Main(string[] args)
        {
            int[] arr = { 3, 6, 8, 10, 56, 67, 78, 99, 34, 100, 76, 77, 88, 99 };

            Console.WriteLine("array value are :");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("value to find :");
            int value = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (value==arr[i])
                {
                    counter += 1;
                    Console.WriteLine("value is at : slot{0}", i+1);
                }
                else
                {
                    Console.WriteLine("value {0} is not present", value);
                }
            }

            Console.WriteLine("the value {0} is there for {1}times", value, counter);

        }
    }
}