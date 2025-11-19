using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player("Ritesh Mishra", 5, 100);
            Console.WriteLine("\nValues from default constructor object:");
            Console.WriteLine("Player Name: " + p1.playerName);
            Console.WriteLine("Level: " + p1.level);
            Console.WriteLine("Health: " + p1.health);

            Console.WriteLine("\nValues from parameterized constructor object:");
            Console.WriteLine("Player Name: " + p2.playerName);
            Console.WriteLine("Level: " + p2.level);
            Console.WriteLine("Health: " + p2.health);
        }
    }
}
