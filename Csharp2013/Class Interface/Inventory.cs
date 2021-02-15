using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Csharp2013.Class_Interface
{
    public class Inventory
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public int onHand { get; set; }

        public Inventory(string n, double c, int h)
        {
            Name = n;
            Cost = c;
            onHand = h;

        }

        public override string ToString()
        {
            return
      String.Format("{0,-10}Cost: {1,6:C}  On hand: {2}",
                    Name, Cost, onHand); 
        }
    }

    //class Inventory
    //{
    //    public static void Main(string[] args)
    //    {
    //        ArrayList inv = new ArrayList();

    //        inv.Add(new Inventory("sfsf",4.65, 2));
    //        inv.Add(new Inventory("sfsf",4.65, 2));
    //        inv.Add(new Inventory("sfsf",4.65, 2));
    //        inv.Add(new Inventory("sfsf", 4.65, 2));

    //    }
        
    //}
}