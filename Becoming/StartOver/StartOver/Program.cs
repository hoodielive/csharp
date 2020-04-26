using System;
using System.IO.Compression;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace StartOver
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Larry";
            person.LastName = "Awo";
            Console.WriteLine("What do you think the name is?");
            string fullNameGuess = Console.ReadLine();

//            while (person.FullName != fullNameGuess)
//            {
//                Console.WriteLine("Guess Again!");
//            }
            if (person.FullName == fullNameGuess)
            {
                Console.WriteLine("You got the juice!");
            }
            else
            {
                Console.WriteLine("Guess again..");
            }
        }
    }
}