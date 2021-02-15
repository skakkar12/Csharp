using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.VARIABLES
{
    class classvariable
    {
        public static void Main(string[] args)
        {

            string fname;

            string lname;

            string grade;

            int studentID;

            string login;

            string GPA;

            Console.WriteLine("enter firstname :");
            fname = Console.ReadLine();

            Console.WriteLine("enter lastname :");
            lname= Console.ReadLine();

            Console.WriteLine("enter grade :");
            grade = Console.ReadLine();

            Console.WriteLine("enter studentid :");
            studentID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter login :");
            login = Console.ReadLine();

            Console.WriteLine("enter GPA:");
            GPA = Console.ReadLine();

        }
    }
}