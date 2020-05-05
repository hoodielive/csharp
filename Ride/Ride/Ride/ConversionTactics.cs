using System;
using System.Collections.Generic;
using System.Linq;

namespace Ride
{
    public class ConversionTactics
    {
        static void Rachel(string[] args)
        {
            List<int> stuff = new List<int>() {5};
            int[] passedStuff = stuff.ToArray();
            
            int[][] studentGrades =
            {
                new int[] {5, 10, 26},
                new int[] {34, 26, 26},
                new int[] {26, 2, 23, 26, 200}
            };

            List<int> myList = studentGrades[0].ToList();
            
            foreach (int[] grades in studentGrades)
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