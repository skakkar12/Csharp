using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp2013.Class
{
    public class data
    {
        public static void Main(String[] args)
        {
            var data1 = new[] { "10", "10", "10" };
            var data2 = new[] { "1", "2", "3", "4" };

            var qry = data1.Zip(data2, (i, d) => i + d);

            foreach (var result in qry)
            {
                Console.WriteLine(result);
            }

        }
    }
}
