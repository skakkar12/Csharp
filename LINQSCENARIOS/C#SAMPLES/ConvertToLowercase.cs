using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;


namespace LINQSCENARIOS.C_SAMPLES
{
    public class ConvertToLowercase
    {
        public static void Main(String[] args)
        {
            conversion convert = new conversion();
            string str = "THIS IS UPPERCASE";
            string result = convert.convertoLowercase(str);
        }
    }

    public class conversion
    {

        internal string convertoLowercase(string str)
        {
            return str.ToLower();
        }
    }
}