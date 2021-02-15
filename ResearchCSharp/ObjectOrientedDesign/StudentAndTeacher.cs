using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.ObjectOrientedDesign
{
    class StudentAndTeacher
    {
        public static void Main(String[] args)
        {
            bool debug = false;

            Person person = new Person();
            person.Greet();


            Student student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();

            if (debug)
            {
                Console.ReadLine();
            }


        }
    }

    class Person
    {
        protected int age;

        public void Greet()
        {
            Console.WriteLine("hello"); 
        }

        public void SetAge(int n)
        {
            age = n;
        }
    }

    class Student:Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", age);
        }
    }
    class Teacher:Person
    {
        private string subject;

        public void Explain()
        {
            Console.WriteLine("explanation begings");
        }
    }


}
