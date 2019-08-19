using System;

class PassByValue
{
	// void Set(int i) { i = 10; }
	void Set(int[] i) { i = new int[] { 10 }; }
	
	static void Main(string[] args)
	{
		PassByValue m  = new PassByValue(); 
		int x = 999; 
		m.Set(x);
		Console.Write(x);
		
		int[] y = { 0 }; 
		m.Set(y); 
		Console.Write(y[0]);
	}
}
