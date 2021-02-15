using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace ResearchCSharp.COLLECTION
{
    public class ArrayListClass
    {
        public static void Main(String[] args)
        {

            NewMethod();

            callnew();

        }

        private static void callnew()
        {
            ArrayList item = new ArrayList();
            item.Add("item1");
            item.Add("item2");

            for (int i = 0; i < item.Count; i++)
            {
                Console.WriteLine(item[i].ToString());
            }

        }

        private static void NewMethod()
        {
            ArrayList ItemList = new ArrayList();
            ItemList.Add("Item4");
            ItemList.Add("Item5");
            ItemList.Add("Item2");
            ItemList.Add("Item1");
            ItemList.Add("Item3");

            for (int i = 0; i < ItemList.Count; i++)
            {
                Console.Write(ItemList[i].ToString());
            }

            ItemList.Insert(3, "item6");
            ItemList.Sort();
            ItemList.Remove("item1");
        }
    }
}
