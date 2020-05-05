using System;

namespace ClassesClass
{
    public class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public void Output()
        {
            Console.WriteLine(Firstname);
            Console.WriteLine(Lastname);
        }
    }
}