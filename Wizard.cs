using System;
namespace WarriorGame
{
    public class Wizard : Character
    {
        public Wizard(string name) : base(name)
        {
            AtkDmg = 25;
            HP = 110;
            MaxHP = 110;
            MaxBlock = 7;
            count = 0;
            DefCount = 0;
        }

        public override void SpecialAttack(BaseEnemy enemy, Character character)
        {
            if (count > 0)
            {
                Console.WriteLine("You have already used the healing ability, so you must use the basic attack\n");
                BasicAttack(enemy, character);
            }
            else
            {
                HP += 50;
                count++;
                Console.WriteLine($"You healed up with 50 extra hp, you now have {HP}hp\n");
            }
        }
    }
}

