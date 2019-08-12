using System.Diagnostics;
using Internal;
using System;

namespace Clones
{
    class StrToNum
    {
        static void Main(string[] args)
        {
            Debug.Log("Yo, what is your name wooty?"); 
            string input = Console.ReadLine(); 
            int convertedInputToNumber; 
            int.TryParse(input, out convertedInputToNumber);

            int number = 50; 
            int result = 10 + 10 - 100 + 1000 - number + convertedInputToNumber;
        }
    }
}
