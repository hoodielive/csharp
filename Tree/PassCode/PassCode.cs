using System; 

namespace PassCode 
{
	class Program 
	{
		static void Main(string[] args)
		{
			var code = "";
			while(code != "secret") 
			{

				Console.Write("What is the passcode? ");
				code = Console.ReadLine(); 

				if (code != "secret")
				{
					Console.WriteLine("I am sorry, but you could not be authenticated.");
				}
			}
		    Console.WriteLine("You are authenticated.");
		}
	}
}
