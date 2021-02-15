using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.NEWEXERCISES
{
    class ArrayNumbers
    {
        public static void Mains(string[] args)
        {
            int[] Numbers = new int[10];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i]%==0)
                {
                    Console.WriteLine("{0} ",   Numbers[i]);
                }
            }
        }

    }
}
