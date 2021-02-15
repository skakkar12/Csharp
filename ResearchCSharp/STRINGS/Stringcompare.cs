using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.STRINGS
{
    class Stringcompare
    {
        public static void Main(String[] args)
        {
            Strincompre();
            stringConcat();
            stringcontains();

            stringEndswith();

            stringsplit();

            stringsubstring();


            stringlength();
        }

        private static void stringlength()
        {
            string str = null;
            str = "This is a Test";
            Console.WriteLine(str.Length.ToString());
        }

        private static void stringsubstring()
        {
            string str = null;
            string retString = null;
            str = "This is substring test";
            retString = str.Substring(8, 9);
            Console.WriteLine(retString);
        }

        private static void stringsplit()
        {
            string str = null;
            string[] strArr = null;
            int count = 0;
            str = "CSharp split test";
            char[] splitchar = { ' ' };
            strArr = str.Split(splitchar);
            for (count = 0; count <= strArr.Length - 1; count++)
            {
                Console.WriteLine(strArr[count]);
            }
        }

        private static void stringEndswith()
        {
            string str = null;
            str = "VB.NET TOP 10 BOOKS";

            if (str.EndsWith("BOOKS") == true)
            {
                Console.WriteLine("The string endswith 'books'");
            }
            else if (true)
            {
                Console.WriteLine("The string does not contain books");
            }
        }

private static void stringcontains()
{
            string str = null;
            str = "csharp TOP 10 BOOKS";

            if (str.Contains("TOP")==true)
            {
                Console.WriteLine("the string contains TOP");
            }
            else if (true)
	        {
		        Console.WriteLine("the string does not contain 'TOP'");
	        }
}

        private static void stringConcat()
        {
            string str1 = null;
            string str2 = null;

            Console.WriteLine(string.Concat(str1, str2));
        }

        private static void Strincompre()
        {
            string str1 = null;
            string str2 = null;

            str1 = "csharp";
            str2 = "CSharp";

            int result = 0;

            result = string.Compare(str1, str2);
            Console.WriteLine(result.ToString());
        }
    }
}