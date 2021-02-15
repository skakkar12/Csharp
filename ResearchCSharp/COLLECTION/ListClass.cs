using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;


namespace ResearchCSharp.COLLECTION
{
    class ListClass
    {
        public static void Main(String[] args)
        {
            NewMethod();

            callMethod();

        }

        private static void callMethod()
        {
            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("black");
            colors.Add("orane");

            colors.Insert(1, "violet");

            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }


        }

        private static void NewMethod()
        {
            List<string> colors = new List<string>();

            //add items in a List collection
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");

            //insert an item in the list
            colors.Insert(1, "violet");

            //retrieve items using foreach loop
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            //remove an item from list
            colors.Remove("violet");

            //retrieve items using for loop
            for (int i = 0; i < colors.Count; i++)
            {
                Console.WriteLine(colors[i]);
            }
        }
    }
}