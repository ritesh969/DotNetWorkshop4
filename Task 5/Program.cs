using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a day: ");
            string day = Console.ReadLine().Trim().ToLower();

            DayType type;
            if (day == "friday" || day == "saturday")
            {
                type = DayType.Weekend;
            }
            else
            {
                type = DayType.Weekday;
            }

            Console.WriteLine("It is: " + type);

            Book book1 = new Book("C# Basics", "John Doe", 500);

            Book book2 = book1 with { title = "Advanced C#", price = 750 };

            // Print first object
            Console.WriteLine("\nFirst Book Details:");
            Console.WriteLine(book1);
            var (title, author, price) = book2;

            Console.WriteLine("\nSecond Book (After Deconstruction):");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }
}
