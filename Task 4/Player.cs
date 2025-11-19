using System;

namespace Task_4
{
    public class Player
    {
        public string playerName;
        public int level;
        public int health;
        public Player()
        {
            Console.WriteLine("Default constructor has been called");
        }

        public Player(string name, int level, int health)
        {
            this.playerName = name;
            this.level = level;
            this.health = health;
        }
    }
}
