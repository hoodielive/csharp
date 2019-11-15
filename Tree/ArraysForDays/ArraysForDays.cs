using System; 

namespace ArraysForDays 
{ 
	class Program 
	{
		static void Main(string[] args)
		{
			var studentGrades = new int[] { 80, 77, 47, 100, 83, 99, 85, 72 }; 

			foreach(var studentGrade in studentGrades)
			{
				Console.WriteLine(studentGrade);
			}
		}
	}
}
