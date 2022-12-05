using System;
namespace WarriorGame
{
    public class Warrior : Character
    {
        public Warrior(string name) : base(name)
        {
            AtkDmg = 25;
            HP = 150;
            MaxHP = 150;
            MaxBlock = 10;
            count = 0;
            DefCount = 0;
        }

        public override void SpecialAttack(BaseEnemy enemy, Character character)
        {
            if (count > 1)
            {
                Console.WriteLine("You have used the special attack too many times, you can only use the regular one now\n");
                BasicAttack(enemy, character);
            }
            else
            {
                int Dmg = rand.Next(enemy.MaxBlock + 1, character.AtkDmg + 10) - rand.Next(2, enemy.MaxBlock + 1);
                enemy.HP -= Dmg;
                count++;
                Console.WriteLine($"You hit the enemy with your special attack and dealt {Dmg} damage, he now has {enemy.HP}hp left \n");
            }
        }
    }
}

