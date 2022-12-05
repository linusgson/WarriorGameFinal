using System;
namespace WarriorGame
{
    public class StartMenu : IMenu
    {
        public void Print()
        {
            Console.WriteLine("███╗░░░███╗░█████╗░██╗███╗░░██╗  ███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗" +
"\n████╗░████║██╔══██╗██║████╗░██║  ████╗░████║██╔════╝████╗░██║██║░░░██║" +
"\n██╔████╔██║███████║██║██╔██╗██║  ██╔████╔██║█████╗░░██╔██╗██║██║░░░██║" +
"\n██║╚██╔╝██║██╔══██║██║██║╚████║  ██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║" +
"\n██║░╚═╝░██║██║░░██║██║██║░╚███║  ██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝" +
"\n╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝╚═╝░░╚══╝  ╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░");
            Console.WriteLine("\n[1]Start game\n[2]Quit");
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

