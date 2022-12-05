using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    public abstract class Character
    {
        public int HP { get; set; }
        public int MaxHP { get; set; }
        private string? name { get; set; } 
        public int AtkDmg { get; set; }
        public int MaxBlock { get; set; }
        public Random rand = new();
        public int count { get; set; }
        public int DefCount { get; set; }

        public Character()
        {

        }

        public Character(string name)
        {
            Name = name;
        }

        public string Name
        {
            get
            {
                if (name == null)
                    throw new ArgumentNullException("name");
                return name;
            }
            set
            {
                name = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public void BasicAttack(BaseEnemy enemy, Character character)
        {
            int Dmg = rand.Next(enemy.MaxBlock + 1, character.AtkDmg + 1) - rand.Next(2, enemy.MaxBlock + 1);
            enemy.HP -= Dmg;
            Console.WriteLine($"You hit the {enemy.Name} for {Dmg}, he now has {enemy.HP}hp left \n");
        }
        public abstract void SpecialAttack(BaseEnemy enemy, Character character);
    } 
}
