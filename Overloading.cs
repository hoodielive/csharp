using System;

class Untitled
{
	static void Main(string[] args)
	{
		public struct Note
		{
			int value; 
			public Note (int semitonesFromA) { value = semitonesFromA; }
			public static Note operator + ( Note x, int semitones )
			{
				return new Note (x.value + semitones); 
				Note B = new Note(2); 
				Note CSharp = B + 2;
			}
		}
	}
}