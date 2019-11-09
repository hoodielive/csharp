using System;

namespace FitnessFrog
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Prompt the user for minutes exercised

            int runningTotal = 0;
            
            bool keepGoing = true;
            
           while(keepGoing)
           {
                Console.Write("Please enter the amount of minutes you exercised or type 'quit' to exit: ");

                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    try
                    {
                        int minutes = int.Parse(entry);
                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not an acceptable value!");
                            continue;
                        }

                        if (minutes <= 10)
                        {
                            Console.WriteLine("Better than nothing, am I right?");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Way to go bro..."); 
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You are a ninja in training.");
                        }
                        else
                        {
                            Console.WriteLine("Okay, now you are just showing off.");
                        }

                        // Add minutes exercised to total

                        runningTotal += minutes;
                        
                        // Display total minutes exercised to the screen 
                
                        Console.WriteLine("You've entered: " + runningTotal + " minutes");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("This is not valid input.");
                        continue;
                    }

                }
           } 
           Console.WriteLine("Goodbye!");
        }
    }
}