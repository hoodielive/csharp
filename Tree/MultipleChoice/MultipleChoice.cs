using System; 

namespace MultipleChoice
{
	class Program 
	{
		static void Main()
		{

			Console.Write("What is your favorite Language? ");
			var fav_lang = Console.ReadLine().ToLower();

			Console.Write("What is your secondary language? ");
			var sec_lang = Console.ReadLine().ToLower(); 

			Console.WriteLine("You have indicated that your favorite language is: {0} ", fav_lang);
			Console.WriteLine("You have indicated that your secondary language is: {0} ", sec_lang);

			while (fav_lang == "")
			{
				Console.WriteLine("If you're going to play this game, you have to enter something!");
			}

			if (fav_lang == "c++")
			{
				Console.WriteLine("You are a Geek!"); 
			}
			else if(fav_lang == "haskell")
			{
				Console.WriteLine("You are a Mathematician.");
			}
			else 
			{
				Console.WriteLine("Do you code?");
			}
		}
	} 
}

