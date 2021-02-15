using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.FIRSTCONTACT
{
    class TempConversion
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter the amount of celcius: ");
            int celcius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celcius + 273);
            Console.WriteLine("Fahrenheit ={0}", celcius * 18 / 10 + 32);
        }
    }
}