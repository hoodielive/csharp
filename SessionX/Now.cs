using System;

class Test
{
	public int a_int = 32;
	public float a_float = 3.14f;
	public double a_double = 32123.32313242424;
	public string name = "Larry";

	public int Main()
	{
		Console.WriteLine(a_int);
		Console.WriteLine(a_float);
		Console.WriteLine(a_double);
		Console.WriteLine(name);

		IfAndElse();
	}

	void IfAndElse()
	{
		if (a_int < 32)
		{
			Console.WriteLine("It is.");
		}
		else 
		{
			Console.WriteLine("It is not.");
		}
	}
}
