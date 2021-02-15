using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ResearchCSharp.PROGRAMMING_EXERCIESES.OPERATORS
{
    class DescribingClass
    {
        public int sampleMember;
        public void SampleMethod() { }

        static void Main()
        {
            Type t;
            //write your code here
            t = typeof(DescribingClass);

            Console.WriteLine("Methods:");
            MethodInfo[] methodInfo = t.GetMethods();

            foreach (MethodInfo mInfo in methodInfo)
                Console.WriteLine(mInfo.ToString());

            Console.WriteLine("Members:");
            MemberInfo[] memberInfo = t.GetMembers();

            foreach (MemberInfo mInfo in memberInfo)
                Console.WriteLine(mInfo.ToString());
            //

        }
    }
}