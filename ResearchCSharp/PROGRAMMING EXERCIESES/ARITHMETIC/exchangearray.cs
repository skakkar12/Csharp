using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.ARITHMETIC
{
    class exchangearray
    {
        public static void Main(string[] args)
        {
            string[] arr = { "first", "second", "third", "fourth", "fifth" };
            int value;

            do
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine("choose the value or -1 to quit ");

                value = int.Parse(Console.ReadLine());  

               
            } while (value!= -1);
        }
    }
}