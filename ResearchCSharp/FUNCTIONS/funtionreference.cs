using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.Funtions
{
    class funtionreference
    {
        public static void Main(String[] args)
        {

            int x = 6;
            int y = 7;

            Swap(ref x, ref y);
            Console.WriteLine("x: {0}, y: {1}", x, y);
        }

        public static void Swap(ref int x, ref int y)
        {
            int swap;
            swap = x;
            x = y;
            y = swap;
        }

    }
}