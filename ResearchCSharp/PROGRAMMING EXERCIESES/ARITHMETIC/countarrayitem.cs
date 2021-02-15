using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ResearchCSharp.PROGRAMMING_EXERCIESES.ARITHMETIC
{
    class countarrayitem
    {
        public static void Main(String[] args)
        {
            int[] arr = { 4, 5, 6, 78, 89, 4, 45, 56, 67, 4, 5, 4 };

            Console.WriteLine("array items are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("item to find :");
            int value = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (value==arr[i])
                {
                    counter += 1;
                }
            }

            Console.WriteLine(" {} was found {0} times ", value, counter);


        }
    }
}