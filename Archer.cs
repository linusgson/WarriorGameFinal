using System;
namespace WarriorGame
{
    public class Archer : Character
    {
        public Archer(string name) : base(name)
        {
            AtkDmg = 18;
            HP = 170;
            MaxHP = 170;
            MaxBlock = 12;
            count = 0;
            DefCount = 0;
        }

        public override void SpecialAttack(BaseEnemy enemy, Character character)
        {
            if (count > 2)
            {
                Console.WriteLine("You are out of fire arrows, you´ll have to use regular ones from now on\n");
                BasicAttack(enemy, character);
            }
            else
            {
                int Dmg = rand.Next(enemy.MaxBlock + 1, character.AtkDmg + 12) - rand.Next(2, enemy.MaxBlock + 1);
                enemy.HP -= Dmg;
                count++;

                Console.WriteLine($"You hit the enemy with a fire arrow and dealt {Dmg} to him, he now has {enemy.HP}hp left\n");
            }
        }
    }
}

