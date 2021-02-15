using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.FLOWCONTROL
{
    class Positivenegative
    {
        public static void Main(String[] args) {
            int a;

            Console.WriteLine("enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a>0)
            {
                Console.WriteLine("is positive ");

            }
            if (a<0)
            {
                Console.WriteLine("is negative");
            }
        
        }
    }
}