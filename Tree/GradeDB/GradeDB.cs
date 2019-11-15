using System; 

namespace GradeDB 
{
	class Program 
	{
		static void  Main(string[] args)
		{
		
		}

		static string StudentRoster(string student_name, string student_grade)
		{
			var student_db = new int[] {}; 

			Console.Write("Please enter the student's firstname only: "); 
			student_name = Console.ReadLine(); 

			Console.Write("Please enter the student's grade: ")
			student_grade = Console.ReadLine(); 

			student_db.push(student_name); 
			student_db.push(student_grade);
		}
	}
}
