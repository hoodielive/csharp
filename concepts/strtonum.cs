using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine(); 

        int convertedInputToNumber; 
        Int.TryParse(input, out convertedInputToNumber); 

        int number = 90;
        int result = 10 + 10 + 1000 - number + convertedInputToNumber;
    }
}