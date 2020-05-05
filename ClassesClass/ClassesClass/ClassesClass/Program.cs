using System;

namespace ClassesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrintName();
        }
        
        public void PrintName()
        {
            User me = new User();
            me.Firstname = "King";
            me.Lastname = "Solomon";
            string msg = me.Output(4);
            Console.Write(msg);
        }
    }
}