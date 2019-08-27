using System;

namespace Home
{
	class Homer
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
		}
		
		public struct Complex
		{
			public double Real { get; set; }
			public double Imaginary { get; set; }
			Complex a = new Complex() { Real = 1, Imaginary = 2 }; 
			Complex b = new Complex() { Real = 4, Imaginary = 8 }; 
			Complex c = a + b; 
		}

		public static Complex operator +(Complex c1, Complex c2)
		{
			return new Complex 
			{
				Real = c1.Real + c2.Real, 
				Imaginary = c1.Imaginary + c2.Imaginary
			}; 
		}
	}
}