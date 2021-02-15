using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.FLOWCONTROL
{
    class MultiplyIfNotZero
    {
        public static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("enter x");
            x = Convert.ToInt32(Console.ReadLine());

            if (x!=0)
            {
                Console.WriteLine("enter y :");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("the product of {0} and {1} is {2}", x, y, x * y);
            }

            if (x==0)
            {
                Console.WriteLine("0");
            }
        }
    }
}