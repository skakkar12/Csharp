using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace ResearchCSharp.COLLECTION
{
    class HashtableClass
    {
        public static void Main(string[] args)
        {


            NewMethod();

            callmethod();
        }

        private static void callmethod()
        {
            
        }

        private static void NewMethod()
        {
            Hashtable weeks = new Hashtable();
            weeks.Add("1", "SunDay");
            weeks.Add("2", "MonDay");
            weeks.Add("3", "TueDay");

            weeks.Add("4", "WedDay");
            weeks.Add("5", "ThuDay");
            weeks.Add("6", "FriDay");
            weeks.Add("7", "SatDay");
            //Display a single Item 

            Console.WriteLine(weeks["5"].ToString());
            //Search an Item 
            if (weeks.ContainsValue("TueDay"))
            {
                Console.WriteLine("Find");
            }
            else
            {
                Console.WriteLine("Not find");
            }
            //remove an Item 
            weeks.Remove("3");
            //Display all key value pairs
            foreach (DictionaryEntry day in weeks)
            {
                Console.WriteLine(day.Key + "   -   " + day.Value);
            }
        }
    }
}
