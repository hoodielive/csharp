using System; 

namespace FirstZ
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			uint ui = 5U; // unsigned integer
			int i = 5; // 
			sbyte sb = 127; 
			decimal m = 30.5M; 
			double d = 30.5D; 
			float f = 30.5F; 
			long l = 5L; 
			ulong ul = 5UL;
			
			string s = "hello, this is a string literal"; 
			
			string sa = @"This path is: 
			~/Clones/csharp";
			
			char c = 'h';
			
			byte b = 127; 
			bool bo = true; 
			
			Console.WriteLine(bo); 
			Console.WriteLine(b); 
			
			Console.WriteLine(c); 
			Console.WriteLine(sa);
			Console.WriteLine(s); 
			Console.WriteLine(ui);
			Console.WriteLine(i);
			Console.WriteLine(sb);
			Console.WriteLine(m);
			Console.WriteLine(d);
			Console.WriteLine(f);
			Console.WriteLine(l);
			Console.WriteLine(ul);
		}
	}
}