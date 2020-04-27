using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Olight
{
    class Program
    {
        private static string helloClass = "Hello Class";
        static void Main(string[] args)
        {
            string helloLocal = "Hello, Local";
            Console.WriteLine(helloLocal);
            Console.WriteLine(Program.helloClass);
            DoStuff();
        }
        static void DoStuff()
        {
            Console.WriteLine("A message from DoStuff: " + Program.helloClass);
        }
    }
}