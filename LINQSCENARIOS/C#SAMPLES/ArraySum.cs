using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;


namespace LINQSCENARIOS.C_SAMPLES
{
    interface IArray
    {
        int Sum(int[] data);
    }

    public class test :IArray
	{

        public int Sum(int[] data)
        {
            int result = 0;
            for (int i = 0; i < data.Length; i++)
            {
                result += data[i];
            }
            return result;
        }

        public static void Main(String[] args)
        {
            test tclass = new test();
            int[] arrclass ={1,2,3,4};
            int data = tclass.Sum(arrclass);
            Console.WriteLine("the result is : " + data);
        }
    }


    

    public class ArraySum
    {
        public static void Main(string[] args)
        {
            SumArray  sum = new SumArray();
            int[] testArray={1,2,3,4};
            int result =sum.AddArray(testArray);
        }
    }

    class SumArray
    {
    
        public int AddArray(int[] testArray)
        {
            int sum = 0;
            for (int i = 0; i < testArray.Length; i++)
            {
                sum += testArray[i];
                
            }
            return sum;
        }
    }
}