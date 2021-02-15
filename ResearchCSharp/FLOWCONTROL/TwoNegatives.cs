using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.FLOWCONTROL
{
    class TwoNegatives
    {
        public static void Main(String[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            if ((num1 < 0) && (num2 <0))
            {
                Console.WriteLine("the nos are negative");
            }

            if (!((num1<0) && (num2<0)))
	        {
		        Console.WriteLine("the nos are not negative");
	        }

        }
    }
}