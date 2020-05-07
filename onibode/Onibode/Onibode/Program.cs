using System;
using System.Collections.Generic;

namespace Onibode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.doSomething();
        }

        public void doSomething()
        {
            User user = new User();
            user.FirstName = "King";
            user.LastName = "Solomon";
            
            Console.WriteLine(user.Output());
        }
    }
}