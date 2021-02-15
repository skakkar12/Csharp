using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.FLOWCONTROL
{
    class DisplayWhile
    {
        public static void Main(String[] args)
        {
            int n = 1;

            while (n<=10)
            {
                Console.WriteLine("{0} ", n);
                n++;
            }
        }
    }
}