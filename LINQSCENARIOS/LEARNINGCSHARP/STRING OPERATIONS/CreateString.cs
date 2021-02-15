using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQSCENARIOS.LEARNINGCSHARP.STRING_OPERATIONS
{
    public static class NewStringOpns
    {
        public static void Main(string[] args)
        {
            string retString;
            string teststring ="this is string";
            retString = CreateString();
            int len = FindStrlength(teststring);
            retString = CloneString(teststring);

        }

        private static string CloneString(string teststring)
        {
            return teststring.Clone().ToString();
        }

        private static int FindStrlength(string teststring)
        {
            return teststring.Length;
        }

        private static string CreateString()
        {
            throw new NotImplementedException();
        }
    }

    interface IStringOperations
    {
        string CreateString(string str);
        int FindStringLength(string str);
        string CloneString(string str);
        char[] GetAllChars(String str);
        void swapString(ref string p, ref string q);
    }


    class stingOpns :IStringOperations
    {
        public void swapString(ref string p, ref string q)
        {
            string temp;
            temp = p;
            p = q;
            q = temp;
        }

        public string CreateString(string str)
        {
            string createNew = str;
            return createNew;
        }

        public int FindStringLength(string str)
        {
            return str.Length;

        }

        public string CloneString(string str)
        {
            return str.Clone().ToString();
        }


        public char[] GetAllChars(string str)
        {
            char[] countChar = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                countChar[i]=str[i];
            }
            return countChar;
        }
    }
    public class StringOperations
    {

        public static void Main(String[] args)
        {
            createAndDefineString();
            FindStringLength();
            CloneString();
            GetAllChars();
            InsertString();
            Substring();

        }

        private static void Substring()
        {
            string sentence = "suman kakkar is author of founder of c#";
            Console.WriteLine("original string {0}", sentence);
            Console.WriteLine("substring starting at 20, {0}", sentence.Substring(20, 20));
        }

        private static void InsertString()
        {
            string sentence = "Mahesh Chand is an author";
            Console.WriteLine("Original String: {0}", sentence);
            string insertString = " and founder of C# Corner";
            sentence = sentence.Insert(sentence.Length, insertString);
            Console.WriteLine("Final String");
            Console.WriteLine(sentence);
            Console.ReadLine(); 
        }

        private static void GetAllChars()
        {
            string namestring = "Mahesh Chand";

            for (int i = 0; i < namestring.Length-1; i++)
            {
                Console.WriteLine(namestring[i]);
            }
        }

        private static void CloneString()
        {
            string firstname = "Suman";
            string lastname = "kakkar";
            string fullname = firstname + " " + lastname;
            string cloneAuthor = fullname.Clone().ToString();
            Console.WriteLine(cloneAuthor);
        }

        private static void FindStringLength()
        {
            string name = "Suman Kakkar";
            Console.WriteLine("The string is {0}:", name);
            Console.WriteLine("The string size is :{0}", name.Length);
        }

        private static void createAndDefineString()
        {
            string authorName = "Mahesh Chand";
            string age = "33";

            Console.WriteLine("Name: {0}", authorName);
            Console.WriteLine("Age: {0}", age);



        }
    }
}