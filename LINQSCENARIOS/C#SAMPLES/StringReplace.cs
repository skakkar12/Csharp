using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace LINQSCENARIOS.C_SAMPLES
{
    public class StringReplace
    {
        public static void Main(string[] args)
        {
            replacestring replace = new replacestring();
            string result;
            string str = "string value";

            result = replace.Createstring(str);
        }

       
    }

    class replacestring
    {


        internal string Createstring(string str)
        {
            Console.Write("before replacing " + str);
            Console.Write("after replacing :" + str.Replace("string", "new string"));
            return str;
        }
    }
}