using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.ARRAYS_STRUCTS_STRINGS
{
    class ArrayPositiveNegative
    {
        public static void Main(String[] args)
        {
            float[] numbers = new float[10];
            float totalPositive = 0.0f;
            float totalNegative = 0.0f;

            int countPositive = 0;
            int countNegative = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number {0} = ", i + 1);
                numbers[i] = Convert.ToSingle(Console.ReadLine());

            }

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i]<0)
                {
                    totalNegative = totalNegative + numbers[i];
                    countNegative++;
                }

                if (numbers[i]>0)
                {
                    totalPositive = totalPositive + numbers[i];
                    countPositive++;
                }
            }

            Console.WriteLine("average nos {0}", totalNegative / countNegative);
            Console.WriteLine("average nos {0}", totalPositive / countPositive);
        }
    }
    }