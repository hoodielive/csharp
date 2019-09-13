using System;


public class Program
{
    public struct Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex()
        {
            Real = c1.Real + c2.Real, 
            Imaginary = c1.Imaginary + c2.Imaginary
        };
    }
    public static void Main()
    {
        Console.WriteLine("Howdy there my friend!");
        
        Complex a = new Complex() { Real = 1, Imaginary = 2 };
        
        Complex b = new Complex() { Real = 4, Imaginary = 6 };

        Complex c = a + b; 
    }
}