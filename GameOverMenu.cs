using System;
namespace WarriorGame
{
    public class GameOverMenu : IMenu
    {
        public void Print()
        {
            Console.WriteLine(
"░██████╗░░█████╗░███╗░░░███╗███████╗  ░█████╗░██╗░░░██╗███████╗██████╗░" +
"\n██╔════╝░██╔══██╗████╗░████║██╔════╝  ██╔══██╗██║░░░██║██╔════╝██╔══██╗" +
"\n██║░░██╗░███████║██╔████╔██║█████╗░░  ██║░░██║╚██╗░██╔╝█████╗░░██████╔╝" +
"\n██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░  ██║░░██║░╚████╔╝░██╔══╝░░██╔══██╗" +
"\n╚██████╔╝██║░░██║██║░╚═╝░██║███████╗  ╚█████╔╝░░╚██╔╝░░███████╗██║░░██║" +
"\n░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝  ░╚════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝");
            Console.WriteLine("YOU DIED, GAME OVER!\n[1] Play again\n[2] Quit");
            string? c = Console.ReadLine();
            switch (c)
            {
                case "1": StartGame.Start(); break;
                case "2": Environment.Exit(0); break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }
}

