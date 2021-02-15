using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.Funtions
{
    class funtionparameters
    {
        public static void sayHello(string name)
        {
            Console.Write("hello " + name);
        }

        public static void saygoodbye()
        {
            Console.Write("good bye");
        }
        public static void Main(string[] args)
        {
            sayHello("john");
            saygoodbye();
        }
    }
}
