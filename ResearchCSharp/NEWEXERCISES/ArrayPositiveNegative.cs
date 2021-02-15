using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.NEWEXERCISES
{
    class ArrayPositiveNegative
    {
        public static void Main(String[] args)
        {
            int totpositive = 0;
            int totnegative = 0;

            int[] Numbers =new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number {0} =", i + 1);
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i]<0)
                {
                    totnegative += 1;   
                }

                if (Numbers[i]>0)
                {
                    totpositive += 1;
                }
            }
        }
    }
}
