using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp2013.Inheritance
{
    public class Plane2
    {
        public double TopSpeed { get; set; }
        public Plane2()
        {
            TopSpeed = 10d;
        }
    }

    public class Jet2:Plane2
    {
        public Jet2()
        {
            TopSpeed = 900D;
        }
    }

    
}