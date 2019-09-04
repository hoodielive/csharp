using System;

class Test
{
	static void Main()
	{
		int x = 12 * 30;
		Console.WriteLine(x);
		Conole.WriteLine(FeetToInches (30));
		Conole.WriteLine(FeetToInches (100));
	}

	static int FeetToInches(int feet)
	{
		int inches = feet * 12;
		return inches;
	}
}
