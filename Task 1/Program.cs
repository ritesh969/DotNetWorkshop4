using System;

namespace Workshop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Now creating the first object...
            Student s1 = new Student();
            s1.name = "Ramesh Sharma";
            s1.age = 20;
            s1.address = "Kathmandu";

            // now creating the second object
            Student s2 = new Student();
            s2.name = "Sita Khadka";
            s2.age = 22;
            s2.address = "Pokhara";

          
            Console.WriteLine("Student 1 Details:");
            Console.WriteLine("Name: " + s1.name);
            Console.WriteLine("Age: " + s1.age);
            Console.WriteLine("Address: " + s1.address);

            Console.WriteLine();

        
            Console.WriteLine("Student 2 Details:");
            Console.WriteLine("Name: " + s2.name);
            Console.WriteLine("Age: " + s2.age);
            Console.WriteLine("Address: " + s2.address);

            Console.WriteLine();

            // Printing the static field....
            Console.WriteLine("College Name: " + Student.collegeName);
        }
    }
}
