using System; 

namespace MultipleChoice
{
	class Program 
	{
		static void Main()
		{

			Console.Write("What is your favorite Language?");
			var fav_lang = Console.ReadLine();

			Console.Write("What is your secondary language");
			var sec_lang = Console.ReadLine(); 

			Console.WriteLine("You have indicated that your favorite language is: {0} ", fav_lang);
			Console.WriteLine("You have indicated that your secondary language is {0} ", sec_lang);


			if (fav_lang == "C++")
			{
				Console.WriteLine("You are a Geek!"); 
			}
		}
	} 
}

