using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.FIRSTCONTACT
{
    class MultiplyUsingVariables
    {
        public static void Main(String[] args)
        {
            int num1;
            int num2;
            int mult;

            Console.WriteLine("enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());

            mult = num1 * num2;
            Console.WriteLine("the multiplication are:");
            Console.WriteLine(mult);

        }
    }
}
