using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParameterDemo demo = new ParameterDemo();

            int value = 5;
            demo.Increase(ref value);
            Console.WriteLine("Increased Value: " + value);

            string fullName;
            demo.GetFullName(out fullName);
            Console.WriteLine("Full Name: " + fullName);

            int total = demo.SumAll(5, 10, 15, 20);
            Console.WriteLine("Sum of Numbers: " + total);
        }
    }
}
