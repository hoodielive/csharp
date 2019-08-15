using System;

class PassByValue
{

	void Set(int i) { i = 10; }
	static void Main(string[] args)
	{
		PassByValue m  = new PassByValue(); 
		int x = 999; 
		m.Set(x);
		Console.WriteLine(x); 
	}
}