using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.ARITHMETIC
{
    class MarkevenNumbers
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("display numbers for 1-20");

            int[] err = new int[10];
           
            for (int i = 1; i <=20; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i + "<");
                }
                else
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}