using System;
namespace WarriorGame
{
    public class Orc : BaseEnemy
    {
        public Orc() : base("Orc")
        {
            HP = 100;
            MaxBlock = 10;
            AtkDmg = 40;
            Message = "I will feast on your skull\n";
        }
        public override void BackgroundColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
    }
}

