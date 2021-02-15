using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Collections;

namespace LINQSCENARIOS.C_SAMPLES
{
    public class arrayreverse
    {
        public static void Main(String[] args)
        {
            ArrayList ar = new ArrayList();
            AddList list = new AddList();
            list.AddItems(ar);

            
        }
    }

    class AddList
    {
       
        internal void AddItems(ArrayList ar)
        {
            ar.Add("first");
            ar.Add("second");

            ar.Add("third");
            ar.Add("fourth");

            ar.Add("fifth");

        }
    }
}