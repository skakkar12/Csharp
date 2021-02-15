using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace ResearchCSharp.FLOWCONTROL
{
    class DivideIfNotZero
    {
        public static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());


            if (num2!=0)
            {
                Console.WriteLine("the result for {0}/{1} is {2} ", num1, num2, num1 / num2);

            }

            if (num2==0)
            {
                Console.WriteLine("no result");
            }
        }
    }
}
