using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorGame;
namespace WarriorGame
{
    public class StartGame
    {
        public static void Start()
        {
            try
            {
                Character character = ChooseCharacter();
                while (character.HP > 0)
                {
                    Fight(character);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static Character ChooseCharacter()
        {
            Console.WriteLine("What is your name?\n");
            string? name = Console.ReadLine();
            
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Everyone has a name\n");
                return ChooseCharacter();
            }
            Console.WriteLine($"\nWelcome {name}, what class do you want to choose? \n[1] Human\n[2] Wizard\n[3] Archer\n");
            string? s = Console.ReadLine();
            if (s is null)
            {
                throw new ArgumentException("Your choice must contain exactly 1 number.");
            }
            char c = Convert.ToChar(s);
            switch (c)
            {
                case '1': return new Warrior(name);
                case '2': return new Wizard(name);
                case '3': return new Archer(name);
                default:
                    Console.WriteLine("Invalid class, choose again\n");
                    return ChooseCharacter();
            }
        }

        static BaseEnemy GetEnemy()
        {
            Console.WriteLine("Who do you want to fight? \n[1] Vampire\n[2] Goblin\n[3] Orc\n ");
            string? s = Console.ReadLine();
            if (s is null)
            {
                throw new ArgumentException("Choice must contain exactly 1 number.");
            }
            char c = Convert.ToChar(s);
            switch (c)
            {
                case '1': return new Vampire();
                case '2': return new Goblin();
                case '3': return new Orc();
                default:
                    Console.WriteLine("Invalid enemy, choose again\n");
                    return GetEnemy();
            }
        }

        public static void Fight(Character character)
        {
            BaseEnemy enemy = GetEnemy();
            Console.WriteLine($"Welcome to the fighting arena {character.Name}, you will fight the {enemy.Name}\n---Let the fight begin---\n");
            while (enemy.HP > 0 && character.HP > 0)
            {
                if (character.HP > 0)
                {
                    Console.WriteLine("Choose your attack: \n[B] Basic \n[S] Special\n");
                    string? s = Console.ReadLine();
                    if (s is null)
                    {
                        throw new ArgumentException("Your choice must contain exactly 1 letter.");
                    }
                    char c = Convert.ToChar(s);
                    switch (c)
                    {
                        case 'b': character.BasicAttack(enemy, character); break;
                        case 's': character.SpecialAttack(enemy, character); break;
                        default:
                            Console.WriteLine("Invalid attack\n");
                            Fight(character);
                            break;
                    }
                }
                if (enemy.HP > 0)
                {
                    enemy.Attack(character, enemy);
                }   
            }
            if (character.HP <= 0)
            {
                GameOverMenu gameover = new();
                gameover.Print();
            }

            if(enemy.HP <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n---CONGRATULATIONS---\nYou defeated the {enemy.Name}\nWhat do you want to do now? \n[1] Refight \n[X] Quit");

                character.HP = character.MaxHP;
                character.count = character.DefCount;

                Console.ForegroundColor = ConsoleColor.White;

                string? s = Console.ReadLine();
                if (s is null)
                {
                    throw new ArgumentException("Your option must contain exactly 1 letter.");
                }
                char c = Convert.ToChar(s);
                switch (c)
                {
                    case '1': Fight(character); break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
