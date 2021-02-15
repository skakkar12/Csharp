using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.FLOWCONTROL
{
    class ReeatUntil
    {
        public static void Main(String[] args)
        {
            int num1;

            Console.WriteLine("enter number :");

            num1 = Convert.ToInt32(Console.ReadLine());

            while (num1!=0)
            {
                Console.WriteLine(num1 * 10);

                Console.WriteLine("enter a number :");
                num1 = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
