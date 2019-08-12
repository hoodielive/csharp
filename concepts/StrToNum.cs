using System;

namespace Clones
{
    class StrToNum
    {
        static void Main(string[] args)
        {
            int convertedInputToNumber; 
            int.TryParse(input, out convertedInputToNumber);

            int number = 50; 
            int result = 10 + 10 - 100 + 1000 - number + convertedInputToNumber;
        }
    }
}
