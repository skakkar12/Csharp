using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.VARIABLES
{
    class VariableAge
    {
        public static void Main(string[] args)
        {
            string name;
            int age;
            float salary;


            Console.WriteLine("Please enter ur name , age and salary :");
            name = Console.ReadLine();

            Console.WriteLine("Please enter ur name , age and salary :");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter ur name , age and salary :");
            salary = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Name: {0}", age);
            Console.WriteLine("Name: {0}", salary);
        }
    }
}