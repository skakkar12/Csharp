using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.FLOWCONTROL
{
    class OddNumbers
    {
        public static void Main(String[] args)
        {
            int n = 15;

            while (n>=15)
            {
                Console.WriteLine(n);
                n -= 2;
            }
        }
    }
}