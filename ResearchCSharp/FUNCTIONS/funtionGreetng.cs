using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.Funtions
{
    class funtionGreetng
    {
        public static void Main(string[] args)
        {
            sayhello();
            saygoodbye();
        }

        private static void saygoodbye()
        {
            Console.Write("goodbye");
        }

        private static void sayhello()
        {
            Console.Write("hello");
        }
    }
}
