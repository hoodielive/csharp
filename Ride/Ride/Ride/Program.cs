using System;
using System.Collections.Generic;

namespace Ride
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> studentGrades = new List<List<int>>()
            {
                new List<int> {5, 10, 26},
                new List<int> {34, 26, 26},
                new List<int> {2, 23, 26, 200}
            };
            
            foreach (List<int> grades in studentGrades.ToArray())
            {
                foreach (int grade in grades)
                {
                    Console.Write(grade + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}