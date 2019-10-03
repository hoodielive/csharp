using System; 

namespace Ask
{
    class Program
    {
        static void Main()
        {
            string thing = "movie";
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("What is your favorite thing " + thing + "? ");
            string favoriteThing = Console.ReadLine();
            Console.WriteLine("My name is "  + name + " and my favorite " + thing + " is " + favoriteThing + ". ");
        }
    }
}