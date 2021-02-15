using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp2013.Inheritance
{
    public class Plane
    {
        public double TopSpeed()
        {
            return 300D;
        }
    }

    public class Jet:Plane
    {
        public double TopSpeed(){
            return 900D;
        }
    }

    class Airport
    {
        //public static void Main(string[] args)
        //{
        //    Plane plane = new Jet();
        //    Console.WriteLine("planes top speed: {0}", plane.TopSpeed());
        //    Console.ReadLine();
        //}
    }
}