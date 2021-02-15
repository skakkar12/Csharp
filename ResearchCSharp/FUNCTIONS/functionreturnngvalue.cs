using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.Funtions
{
    class functionreturnngvalue
    {
        public static int Sum(int a, int b)
        {
            int result;
            result = a + b;
            return result;
        }

        public static void Main(String[] args)
        {
            int x = 4;
            int y = 6;
            Console.Write( Sum(x,y));
        }

    }
}
