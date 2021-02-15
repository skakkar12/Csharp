using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.Common;

namespace LINQSCENARIOS.C_SAMPLES
{

    interface diffoperators
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Div(int a, int b);
    }

    public class difftestoperators: diffoperators
    {

        public int Add(int a, int b)
        {
            return (a + b);
        }

        public int Sub(int a, int b)
        {
            return (a - b);
        }

        public int Div(int a, int b)
        {
            return (a / b);
        }
    }


    public class ClassOperators
    {
        public static void Main(String[] args)
        {
            DifferentOperators operators = new DifferentOperators();
            int result;
            int a = 10;
            int b = 20;

            result = operators.Add(a, b);
            result = operators.Subtract(a,b);
            result = operators.Multiply(a,b);
            result = operators.Divide(a, b);

        }

       
    }

    class DifferentOperators
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}