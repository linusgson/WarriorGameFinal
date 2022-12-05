using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorGame;
namespace WarriorGame
{   
    public abstract class BaseEnemy
    {
        public string Name { get; protected set; } = "Enemy";
        public string? Message { get; set; } = "No message";
        public int AtkDmg { get; set; } 
        public int HP { get; set; }
        public int MaxBlock { get; set; }
        public Random rand = new();

        public BaseEnemy()
        {

        }

        public BaseEnemy(string? name)
        {
            Name = name;
        }
        public abstract void BackgroundColor();

        public void Attack(Character character, BaseEnemy enemy)
        {
            int Dmg = enemy.rand.Next(character.MaxBlock + 1, enemy.AtkDmg + 1) - character.rand.Next(2, character.MaxBlock + 1);
            character.HP -= Dmg;
            enemy.BackgroundColor();
            Console.WriteLine(enemy.Message);
            Thread.Sleep(1000);

            if (character.HP < 0) character.HP = 0;
            Console.WriteLine($"{enemy.Name} hits you for {Dmg} damage, you now have {character.HP} HP left.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------------------------\n");

        }
    }
}
