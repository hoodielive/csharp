using System;

namespace Pro 
{
	class Program 
	{
		static int Main(string[] args)
		{
			string[] theArgs = Environment.GetCommandLineArgs(); 
			foreach (string arg in theArgs)
				Console.WriteLine("Arg: {0}", arg);

			ShowEnvironmentDetails(); 
			Console.ReadLine(); 
			return -1;
		}
	}
}
