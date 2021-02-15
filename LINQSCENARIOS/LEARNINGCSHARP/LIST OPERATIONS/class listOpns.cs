using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace LINQSCENARIOS.LEARNINGCSHARP.LIST_OPERATIONS
{
   
    interface IListOperations
    {
        List<string> CreateList(string[] values);
        List<string> insertList(List<string> listvalues, string val);
        string FindElementList(List<string> lstvalues, string val);
        int CountList(List<string> lstValues);
    }
    class ListOperations
    {

        public List<string> CreateList(string[] values)
        {
            List<string> lstvalues = new List<string>();
            foreach (var item in values)
            {
                lstvalues.Add(item);
            }
            return lstvalues;
        }

        public List<string> insertList(List<string> listvalues, string val){

            listvalues.Add(val);
            return listvalues;
        }

        public string FindElementList(List<string> lstvalues, string val)
        {
            foreach (var item in lstvalues)
            {
                if (item==val)
                {
                    return item;
                }
               
            }
            return null;
        }

        public int CountList(List<string> lstValues)
        {
            return lstValues.Count;
        }
    }

    
    public class class_listOpns
    {
         public static void Main(string[] args)
        {
            CreateList();

            InsertList();

            CountList();



            FindElementList();
        }

        private static void FindElementList()
        {
            List<int> primes = new List<int>(new int[] { 10, 4, 16 });
            foreach (int number in primes)
            {
                if (number == 4)
                {
                    Console.WriteLine("Contains 4");
                    Console.Read();
                }
            }
        }

      


        private static void CountList()
        {
            List<bool> list = new List<bool>();
            list.Add(true);
            list.Add(true);
            list.Add(false);
            list.Add(true);
            list.Add(false);
            Console.WriteLine(list.Count);
            list.Clear();
            Console.WriteLine(list.Count);
            Console.ReadLine();
        }

        private static void InsertList()
        {
            List<string> Man = new List<string>();
            Man.Add("Raju");
            Man.Add("satish");
            Man.Add("sandeep");
            Man.Add("narender");
            Man.Add("Ravinder");
            Man.Add("satender");
            Man.Insert(4, "Manoj");
            foreach (string value in Man)
            {
                Console.WriteLine(value);
                Console.ReadLine();
            }
        }

        private static void CreateList()
        {
            List<int> list1 = new List<int>();
            list1.Add(11);
            list1.Add(12);
            list1.Add(13);
            list1.Add(14);

            Console.WriteLine("the list is :");
            foreach (var item in list1)
            {
                Console.WriteLine(list1[item]);
            }
        }
    }
}