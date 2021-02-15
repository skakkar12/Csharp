using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.ARRAYS_STRUCTS_STRINGS
{
    class ArraySort
    {
        public static void Main(String[] args)
        {
            int total = 9;
            int[] data = new int[total];
            int i, j, aux;

            for (i = 0; i < total; i++)
            {
                Console.Write("enter number {0} ", i + 1);
                data[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (i = 0; i < total-1; i++)
            {
                for (int j = i+1; j < total; j++)
                {
                    if (data[i]>data[j])
                    {
                        aux=data[i];
                        data[i] = data[j];
                        data[j] = aux;
                    }
                }
            }

            Console.Write("sorted");

            foreach (int value in data)
            {
                Console.Write("{0}", value);
            }
        }
    }
}