using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp2013.Class_Interface
{
    abstract class MotorVehicle
    {
        public string make;
        public string model;

        public MotorVehicle(string make, string model)
        {
            this.make = make;
            this.model = model;

        }

        abstract public void Accelerate();
    }

    //public class Product: MotorVehicle
    //{
    //    public Product(string make,string model):base(make, model)
    //    {

    //    }

    //    public override void Accelerate()
    //    {
    //        Console.WriteLine("ssfsf");
    //    }
    //}
}