using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.OPERATORS
{
    class MultiplesSum
    {
        public static void Main(String[] args)
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if ((i%3==0) && (i%5==0))
                {
                    sum += i;
                }
            }
            Console.WriteLine("The total sum is : {0}", sum);
        }
    }
}