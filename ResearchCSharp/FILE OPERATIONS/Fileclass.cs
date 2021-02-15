using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ResearchCSharp.FILE_OPERATIONS
{
    class Fileclass
    {
        public static void Main(String[] args)
        {
            if (File.Exists("c:\\testFile.txt"))
            {
                Console.WriteLine("file does not exist");
            }
            else
	        {
                File.Create("c:\\testfile.txt");
                Console.WriteLine("File exists");
	        }
        }

    }
}