using System;
namespace WarriorGame
{
    public class Vampire : BaseEnemy
    {
        public Vampire() : base("Vampire")
        {
            HP = 100;
            MaxBlock = 10;
            AtkDmg = 40;
            Message = "Give me your blood\n";
        }
        public override void BackgroundColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}

