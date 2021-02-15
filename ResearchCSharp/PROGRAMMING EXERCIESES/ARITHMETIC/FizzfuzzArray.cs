using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;


namespace ResearchCSharp.PROGRAMMING_EXERCIESES.ARITHMETIC
{
    class FizzfuzzArray
    {
        public static void Main(string[] args)
        {
            int[] data = { 1, 3, 45, 7, 8, 5, 7, 8 };

            for (int i = 0; i < data.Length; i++)
            {

                if (i%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i%5==0)
                {
                    Console.WriteLine("Fuzz");

                }
                else if ((i%3==0)&&(i%5==0))
                {
                    Console.WriteLine("FizzFuzzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}