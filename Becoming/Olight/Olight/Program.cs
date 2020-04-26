using System;
using System.Linq;
using System.Linq.Expressions;

namespace Olight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grades = {
                new int[]{5, 4, 7, 3},
                new int[]{7, 3, 2, 6},
                new int[]{5, 7, 3, 3},
            };
            Console.WriteLine(grades.Length);
            Console.WriteLine(grades[1].Length);

            for (int i = 0; i < grades.Length; i++)
            {
                for (int k = 0; k < grades[i].Length; k++)
                {
                    Console.Write(grades[i][k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}