using System; 
using System.Collections;
using System.Collections.Generic;


public class Arrays
{
	static void Main(string[] names)
	{
		foreach (string name in names)
		{
			Console.WriteLine(name);
		}
	}

	static string[] GenerateNames()
	{
		string[] names = new string[4]; 
		names[0] = "Gamma"; 
		names[1] = "Vlissides"; 
		names[2] = "Johnson"; 
		names[3] = "Helm"; 
		return names; 
	}
}
