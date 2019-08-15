using System;

class MyApp
{
	static void Main() 
	{
		MyApp  m = new MyApp(); 
		m.MyPrint("Howdy", " Partner!", "I ", "Can", "see ", "it", "now");
		
		MyApp n = new MyApp(); 
		n.MyPrint(47); 
		
		MyApp o = new MyApp(); 
		o.MyPrint(44.2f);
	}
	
	// void MyPrint(string s1, string s2)
	void MyPrint(params string[] s)
	{
		foreach (string x in s)
		{
			Console.WriteLine(x); 
		} 
	}
	
	void MyPrint(int i)
	{
		Console.WriteLine(i);
	}
	
	void MyPrint(float f)
	{
		Console.WriteLine(f);
	}
}