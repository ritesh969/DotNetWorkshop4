using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Now Creating the object of Calculator....
            Calculator calc = new Calculator();

            // Calling the methods...
            calc.PrintWelcome();

            int sum = calc.Add(10, 5);
            Console.WriteLine("Addition: " + sum);

            int multiply1 = calc.Multiply(10, 5);
            Console.WriteLine("Multiplication (10 * 5): " + multiply1);

            int multiply2 = calc.Multiply(10);  
            Console.WriteLine("Multiplication with default (10 * 1): " + multiply2);
        }
    }
}
