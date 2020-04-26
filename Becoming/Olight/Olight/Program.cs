using System;

namespace Olight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo noob wuts ur age?");
            int age = Int32.Parse(Console.ReadLine());
            if (age > 12)
            {
                Console.WriteLine("Welcome, youre at least a teenager");
            }
        }
    }
}