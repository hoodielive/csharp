﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJourney
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Hood";
            var isWorking = false; 

            byte overflow = 25; 
            overflow += overflow;
            Console.WriteLine("Number is: " + overflow);
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0}{1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0}{1}", float.MinValue, float.MaxValue);


        }
    }
}
