using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Clones
{
    class StrToNum
    {
        static void Main(string[] args)
        {
            string message = ("Yo, what is your name wooty?"); 
            Debug.Log(message);
            string input = Console.ReadLine(); 
            int convertedInputToNumber; 
            int.TryParse(input, out convertedInputToNumber);

            int number = 50; 
            int result = 10 + 10 - 100 + 1000 - number + convertedInputToNumber;
        }
    }
}
