using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ResearchCSharp.FILE_OPERATIONS
{
    class Directoryclass
    {
        public static void Main(string[] args)
        {
            if (Directory.Exists("c:\\testDir1"))
            {
                //shows message if testdir1 exist 
                Console.WriteLine("Directory 'testDir' Exist ");
            }
            else
            {
                //create the directory testDir1 
                Directory.CreateDirectory("c:\\testDir1");
                Console.WriteLine("testDir1 created ! ");
                //create the directory testDir2 
                Directory.CreateDirectory("c:\\testDir1\\testDir2");
                Console.WriteLine("testDir2 created ! ");
                //move the directory testDir2 as testDir in c:\ 
                Directory.Move("c:\\testDir1\\testDir2", "c:\\testDir");
                Console.WriteLine("testDir2 moved ");
                //delete the directory testDir1 
                Directory.Delete("c:\\testDir1");
                Console.WriteLine("testDir1 deleted ");
            }

        }
    }
}
