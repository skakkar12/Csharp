using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ResearchCSharp.COLLECTION
{
    class ArrayClass
    {
        public static void Main(String[] args)
        {
            NewMethod();

            callMethod();
        }

        private static void callMethod()
        {
            string[] week = new string[7];
            week[0] = "sunday";
            week[1] = "Monday";
            week[3] = "Tuesday";
            week[4] = "wednesday";

            foreach (var item in week)
            {
                Console.Write(" day is :" + item);
            }
        }

        private static void NewMethod()
        {
            string[] week = new string[7];
            week[0] = "Sunday";
            week[1] = "Monday";
            week[2] = "Tuesday";
            week[3] = "Wednsday";
            week[4] = "Thursday";
            week[5] = "friday";
            week[6] = "Saturday";

            foreach (string day in week)
            {
                Console.WriteLine(day);
            }
        }
    }
}
