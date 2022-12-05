using System;
namespace WarriorGame
{
    public class Goblin : BaseEnemy
    {
        public Goblin() : base("Goblin")
        {
            HP = 100;
            MaxBlock = 10;
            AtkDmg = 40;
            Message = "I will kill you\n";
        }
        public override void BackgroundColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}

