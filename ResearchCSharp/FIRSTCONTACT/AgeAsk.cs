using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace ResearchCSharp.FIRSTCONTACT
{
    class AgeAsk
    {
        public static void Main()
        {
            NewMethod();

            callMethod();

        }

        private static void callMethod()
        {
            int age;

            Console.WriteLine("enter ur age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("u look younger than {0} ", age);

            int name;
            Console.WriteLine("enter ur name :");
            name = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ur name is :" + name);

        }

        private static void NewMethod()
        {
            int age;
            Console.WriteLine("enter ur age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("u look younger than {0} ", age);


            int name;
            Console.WriteLine("enter ur name :");
            name = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ur name is :" + name);
        }
    }
}