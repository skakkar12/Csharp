using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQSCENARIOS.TESTPUTPUTS
{
    class HelloBase { public void HelloOne() { Console.WriteLine("Hello 1 from base"); } public virtual void HelloTwo() { Console.WriteLine("Hello 2 from base"); } }
    class HelloChild : HelloBase { public new void HelloOne() { Console.WriteLine("Hello 1 from child"); } public override void HelloTwo() { Console.WriteLine("Hello 2 from child"); } }
    static class Program { static void Main(string[] args) { HelloBase hello = new HelloChild(); hello.HelloOne(); hello.HelloTwo(); ((HelloChild)hello).HelloOne(); ((HelloChild)hello).HelloTwo(); } }
}