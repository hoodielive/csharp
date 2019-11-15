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

			fav_lang = TryAgain(fav_lang); 

		}
			static string TryAgain(string fav_lang)
			{
				if (fav_lang == " ")
				{
					Console.WriteLine("If you're going to play this game, you have to enter something!");
				}
				else 
				{

					Console.WriteLine("You have indicated that your favorite language is: {0} ", fav_lang);
				}
				return fav_lang;
			}
	} 
}

