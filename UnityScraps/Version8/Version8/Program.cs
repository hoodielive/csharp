using System;

namespace Version8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var empInfo = new Tuple<int, string, string, DateTime, bool>(100, "Larry", "Man", new DateTime(), false);
            Console.WriteLine(empInfo.Item1);
            Console.WriteLine(empInfo.Item2);
            Console.WriteLine(empInfo.Item3);
            Console.WriteLine(((DateTime)(empInfo.Item4)).ToShortDateString());
            Console.WriteLine(empInfo.Item5);
            
            // TODO: Fix this crap
            var studentInfo = Tuple.Create(5, "Asiri", "Awo", new DateTime(2013, 10, 27));
            Console.WriteLine(studentInfo.Item1);
            Console.WriteLine(studentInfo.Item2);
            Console.WriteLine(studentInfo.Item3);
            Console.WriteLine(studentInfo.Item4);
        }
    }
}