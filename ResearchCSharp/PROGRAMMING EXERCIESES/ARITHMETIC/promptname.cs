using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.ARITHMETIC
{
    class promptname
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("what is ur name :");
            string name = Console.ReadLine();

            int counter=10;

            if (name.Equals("Michell"))
            {
                counter = 5;
            }

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}