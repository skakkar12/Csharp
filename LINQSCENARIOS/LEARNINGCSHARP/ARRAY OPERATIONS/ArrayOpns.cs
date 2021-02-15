using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQSCENARIOS.LEARNINGCSHARP.ARRAY_OPERATIONS
{
    public class ArrayOpns
    {
        public static void Main(string[] args)
        {
            CreateStringArray();


            CreateSingleDimArray();


            ParamsArray();

            ForLoopArray();
        }

        private static void ForLoopArray()
        {
            int[] array = { 100, 300, 500, 700, 900, 1000 };
            // Use for loop.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }

        private static void ParamsArray()
        {
            Console.WriteLine("Parameter Array Function Testing ...");

            int result = 0;

            /* function allowing 3 arguments */
            result = Add(10, 15, 20);
            Console.WriteLine("Result for 3 Prameter :{0}", result);
            Console.ReadKey();
        }

        private static int Add(params int[] nums)
        {
            int total = 0;
            foreach (int i in nums)
            {
                total = total + i;
            }
            return total;
        }


        //private static int Add(params int[] nums)
        //{
        //    int total = 0;

        //    foreach (var i in nums)
        //    {
        //        total += total;
        //    }
        //}


        private static void CreateSingleDimArray()
        {
            // Create a single-dimensional array.
            int[] arr = new int[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Enter array element : ", x);
                arr[x] = Int32.Parse(Console.ReadLine());
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }


       

        private static void CreateStringArray()
        {
            try
            {
                string[] week = new string[7];
            week[0] = "Sunday";
            week[1] = "Monday";
            week[2] = "Tuesday";
            week[3] = "Wednsday";
            week[4] = "Thursday";
            week[5] = "friday";
            week[6] = "Saturday";

            foreach (string strweek in week)
            {
                Console.WriteLine(strweek);
            }
            Console.ReadKey();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}