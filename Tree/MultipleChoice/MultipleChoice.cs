using System; 

namespace MultipleChoice
{
	class Program 
	{
			static string TryAgain(string question)
			{
				Console.Write("What is your favorite Language? ");
				question = Console.ReadLine().ToLower();
				if (question == "")
				{
					Console.WriteLine("If you're going to play this game, you have to enter something!");
					return Console.ReadLine();
				}
				return question;
			}

			static void Main(string[] args)
			{

			}

	}
}

