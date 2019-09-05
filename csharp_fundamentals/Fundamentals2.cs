using System; 

namespace ProgrammingGuide 
{
	public class CustomCalss
	{
		// Property
		public int Number { get; set; } 

		// Method
		public int Multiply (int num) 
		{
			return num * Number; 
		}

		// Instance Constructor
		public CustomClass()
		{
			Number = 0; 
		}
	}

	public class Program
	{
		static void Main(string[] args)
		{
			CustomClass custClass = new CustomClass(); 

			custClass.Number = 27;

			int result = custClass.Multiply(24);

			Console.WriteLine($"The result is {result}."); 
		}
	}
}
