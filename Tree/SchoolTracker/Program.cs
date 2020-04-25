using System; 
using System.Collections.Generic; 

namespace SchoolTracker 
{
	class Program
	{
		static void Main(string[] arg)
		{
			Console.WriteLine("How many students is in your class?"); 
			
			var student = new Student();

			student.Name =  "osameji";
			Console.WriteLine(student.Name);

			var studentCount = int.Parse(Console.ReadLine()); 

			var studentNames = new List<string>(); 

			var studentGrades = new List<int>(); 

			var adding = true; 

			while(adding) 
			{

				Console.Write("Student Name: ");
				studentNames.Add(Console.ReadLine());

				Console.Write("Student Grade: ");
				studentGrades.Add(int.Parse(Console.ReadLine())); 

				Console.WriteLine("Add another? y/n");

				if (Console.ReadLine() != "y");
					adding=false; 
			}

			foreach ( var studentGrade in studentGrades )
			{
				Console.WriteLine(studentGrade);
			}

			for (int i = 0; i < studentNames.Count; i++)
			{ 
				Console.WriteLine("Student Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
			}
		}
	}
}

class Student
{
	public string Name; 
	public int Grade; 
	public string Birthday; 
	public string Address; 
	public int Phone; 
}
