using System; 

namespace SchoolTracker 
{
	class Program
	{
		static void Main(string[] arg)
		{
			Console.WriteLine("How many students is in your class?"); 
			var studentCount = int.Parse(Console.ReadLine()); 

			var studentNames = new string[studentCount];

			var studentGrades = new int[studentCount]; 

			for (int i = 0; i < studentCount; i++)
			{
				Console.Write("Student Name: ");
				studentNames[i] = Console.ReadLine(); 

				Console.Write("Student Grade: ");
				studentGrades[i] = int.Parse(Console.ReadLine()); 
			}

			foreach ( var studentGrade in studentGrades )
			{
				Console.WriteLine(studentGrade);
			}

			for (int i = 0; i < studentCount; i++)
			{ 
				Console.WriteLine("Student Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
			}
		}
	}
}
