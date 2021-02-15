using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.FIRSTCONTACT
{
    class Averagecalculation
    {
        public static void Main(String[] args)
        {
            int num1, num2, num3, result;

            Console.WriteLine("enter first no:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 2nd no:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 3rd no: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            result = (num1 + num2 + num3) / 3;

            Console.WriteLine("the average of {0}, {1}, {2} is {4}", num1, num2, num3, result);





        }

        
    }
}
