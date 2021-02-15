using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp2013.Class
{

   
    public class AccessModifiers
    {
        public string make;
        protected internal string model;
        internal string color;
        protected int horsepower = 150;
        private int yearBuilt;


        public void SetYearBuilt(int yearBuilt)
        {
            this.yearBuilt = yearBuilt;
        }

        public void GetYearBuilt()
        {
        }

        public void Start()
        {
        }

        public void TurnStarterMotor()
        {
        }
    }

    class MainClass
    {
        //public static void Main()
        //{
        //    AccessModifiers modifiers = new AccessModifiers();
        //    modifiers.make = "Toyota";
        //    modifiers.model = "MR2";
        //    modifiers.color = "black";

        //    modifiers.SetYearBuilt(1985);
        //    modifiers.Start();

        //}
    }
}