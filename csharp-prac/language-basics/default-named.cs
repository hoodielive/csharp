using System; 

class Appology 
{
	static void Main(string[] args)
	{
		new Appology().MySum(k: 1, i: 3); 	
	}
	
	void MySum(int i, int j = 0, int k = 0)
	{
		Console.WriteLine(i * i + 2 * j + 3 * k); 
	}
	
}