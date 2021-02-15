using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Deployment;


namespace Csharp2013.Linq
{
    public class ClsLinq
    {
        public static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                //The File.ReadAllLines() opens a text file, reads all lines of the file into a string array, 
               var v = File.ReadLines("dictionary.txt");


                //It stores the first command line argument
                var v1 = args[2];


                //It stores the second command line argument
               var v2 = args[3];


                //  it searches the string variable v which holds the complete dictionary values in the form of array
                //  And it takes out the first v1 value from the sequence
                //  And assigns the value to the first variable
                var first = v.Where(w => w == v1).First();


                //  it searches the string variable v which holds the complete dictionary values in the form of array
                //  And it takes out the first v2 value from the sequence
                //  And assigns the value to the last variable
                var last = v.Where(w => w == v2).First();


                //It searches the variable first in the array v, and finds its index value and assigns to the variable l.
                var l = Array.IndexOf(v.ToArray(), first);


                //It searches the variable last in the array v, and finds its index value and assigns to the variable l2
                var l2 = Array.IndexOf(v.ToArray(), last);


                //It calculates the value of l3
                var l3 = l2 - l;


                // skip specifies the l no. of values to be skipped in the atring of array called v.
                // Take specifies to take the next l3 no of values in the string of array called v and 
                // assign to the variable called results in the form of array
                var results = v.Skip(l).Take(l3);


                // The foreach loops through the entire array
                // and prints the value from the array
                // and writes down to the console
                foreach (var result in results)
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                //It changes the foreground color to be dark red
                Console.ForegroundColor = ConsoleColor.DarkRed;

                
                //It prints the Arguements Invalid to the console in the dark red color if there are not any command line arguments specified.
                Console.WriteLine("Arguments invalid");
            }
        }
    }
}


// Please provide written answers to the questions below.
// 1. What is this code doing?
//Above it is defined in the comments what the code is doing line line, please go through the code description



// 2. Comment on the quality of this code / how could you improve this implementation?
//Ans)The quality of the code is okay, but it can be improved better
//Comment your code, but not too much, just make it simple to understand.


//Use readable variable names  and no more v1 or v1 as they are specified in the code above


//Do use PascalCasing for class names and method names.


//Do use camelCasing for method arguments and local variables.


//Keep Class Size Small
//The single responsibility principle states that every object should have a single responsibility, and that responsibility 
//should be entirely encapsulated by the class. All its services should be narrowly aligned with that responsibility.



//Keep Method Short
//The more lines of code in a method the harder it is to understand.Everyone recommends 20-25 lines of code is ok.But some 
//geeks prefer 1-10 lines for safety, this their personal preference.There is no hard and fast rule.Extract Method is one of 
//the most common refactoring. If you consider a method that is too long or needs a comment to understand its purpose.You can
//apply Extract Method there with little effort.People always keep asking on the length for a method. But length is not the 
//issue.When you are dealing with complex methods, keeping track of all local variables can be complicated and time-consuming.
//Where extracting a method can be a real time-saver.You can use the Visual Studio extract method which will track which 
//variables are passed to a new method, which are returned by the method’s return value as output parameters


//Use Unit testing or ib best use TDD


//other characteristic of good code is
//Simple, but not simplistic
//readable and easy to understand
//maintainable
//extensible
//decoupled
//efficient
//self-documented
//testable


// 3. How could you verify the behaviour is correct?
//Unit tests give developers and testers a quick way to look for logic errors in the methods of classes in Visual C#.
//A unit test can be created one time and run every time that source code is changed to make sure that no 
//bugs are introduced.
//You can use MSTests or Nunits for the unit testing purpose