using System;

namespace Task_6
{
    internal class Task6_Debugging
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks: ");
            string? marksInput = Console.ReadLine();

            Console.Write("Enter total: ");
            string? totalInput = Console.ReadLine();

            int marks;
            int total;

            // Using TryParse
            bool isMarksValid = int.TryParse(marksInput, out marks);
            bool isTotalValid = int.TryParse(totalInput, out total);

            if (!isMarksValid || !isTotalValid)
            {
                Console.WriteLine("Invalid numbers entered!");
                return;
            }

            // Breakpoint 1 
            double percentage = (double)marks / total * 100;   

            // Breakpoint 2 
            Console.WriteLine("Percentage = " + percentage);
        }
    }
}
