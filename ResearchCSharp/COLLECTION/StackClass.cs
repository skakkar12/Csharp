using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ResearchCSharp.COLLECTION
{
    class StackClass
    {
        public static void Main(String[] args)
        {
            Stack days = new Stack();
            days.Push("SunDay");
            days.Push("MonDay");
            days.Push("TueDay");
            days.Push("WedDay");
            days.Push("ThuDay");
            days.Push("FriDay");
            days.Push("SaturDay");
            if (days.Count == 7)
            {
                Console.WriteLine(days.Pop().ToString());
            }
            else
            {
                Console.WriteLine("SaturDay does not exist");
            }
        }
    }
}
