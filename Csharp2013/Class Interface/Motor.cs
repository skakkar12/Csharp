using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp2013.Class_Interface
{
    abstract class Motor
    {
        public string make;
        public string model;


        public Motor(string m, string md)
        {
            make = m;
            model = md;
        }

        abstract public void Accelerate();
    }


    //public class Car:Motor
    //{
    //    public Car(string m, string md):base(m, md)
    //    {

    //    }

    //    public override void Accelerate()
    //    {
    //        throw new NotImplementedException();
    //    }
        
    //}
}