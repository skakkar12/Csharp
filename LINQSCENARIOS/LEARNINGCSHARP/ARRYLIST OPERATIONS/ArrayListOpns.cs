using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace LINQSCENARIOS.LEARNINGCSHARP.ARRYLIST_OPERATIONS
{
    public class ArrayListOpns
    {
        public static void Main(string[] args)
        {
            CreateList();
            ClearArrayList();


            SortArrayList();


            InsertArrayList();

            RemoveArrayList();

            DisplayArrayList();
        }

        private static void DisplayArrayList()
        {
            ArrayList arraylist1 = new ArrayList();
            arraylist1.Add(5);
            arraylist1.Add(7);
            arraylist1.Add(10);
            arraylist1.Add(15);
            arraylist1.Add(23);
            //display elements of the arraylist using foreach loop
            Console.WriteLine("The elements of the arraylist are:");
            foreach (int i in arraylist1)
            {
                Console.WriteLine(i);
            }
            //display elements of the arraylist using for loop
            Console.WriteLine("The elements of the arraylist are:");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(arraylist1[i]);
            }
        }

        private static void RemoveArrayList()
        {
            ArrayList arr = new ArrayList();
            arr.Add("Red");
            arr.Add("Pink");
            arr.Add("Orange");
            arr.Add("Yellow");
            arr.Add("Blue");
            arr.Add("Gray");
            arr.Add("White");
            Console.WriteLine("The elements in the arraylist are:");
            foreach (object obj in arr)
            {
                Console.WriteLine(obj);
            }
            arr.Remove("Orange");
            arr.Remove("Gray");
            arr.Remove("White");
            Console.WriteLine("After perform the remove operation the arraylist are:");
            foreach (object obj in arr)
            {
                Console.WriteLine(obj);
            }
        }

        private static void InsertArrayList()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(10);
            numbers.Add(22);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(9);
            Console.WriteLine("The elements of the arraylist are:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.Insert(0, "One");
            numbers.Insert(4, "Two");
            numbers.Insert(5, "Three");
            Console.WriteLine("After performing the insert operation the arraylist is:");
            foreach (object i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        private static void SortArrayList()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(10);
            numbers.Add(22);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(9);
            Console.WriteLine("The elements of the arraylist are:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.Sort();
            Console.WriteLine("After sorting the elements of the arraylist are:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        private static void ClearArrayList()
        {
            ArrayList months = new ArrayList();
            months.Add("march");
            months.Add("april");
            months.Add("may");
            months.Add("june");
            months.Add("july");
            //before apply the clear method
            Console.WriteLine("The elements in the arraylist are:" + months.Count);
            months.Clear();
            Console.WriteLine("After apply the clear method the arraylist is:" + months.Count);
        }

        private static void CreateList()
        {
            ArrayList ar = new ArrayList();
            ar.Add("Jan");
            ar.Add("Feb");
            ar.Add("March");
            ar.Add("April");
            ar.Add("May");
            ar.Add("June");
            ar.Add("July");
        }
    }
}