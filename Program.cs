using System;
using ComandPattern.Commands;

namespace ComandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte einen Spieltitel eingeben: ");
            var name = Console.ReadLine();
            string command;
            var game = new Game(name);
            var commandController = new CommandController();
            commandController.InitializeGame(game);
            Console.Write("Gib ein Kommando für " + name + " ein: ");

            while ((command = Console.ReadLine()) != "exit")
            {
                commandController.ExecuteCommand(command);
                Console.Write("Gib ein Kommando für " + name + " ein: ");
            }
        }
    }
}
