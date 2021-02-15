using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace ResearchCSharp.NEWEXERCISES
{
    class listdataclass
    {
        public static void Main(String[] args)
        {
            List<string> colors = new List<string>();

            colors.Add("red");
            colors.Add("blue");

            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }

        }
    }
}
