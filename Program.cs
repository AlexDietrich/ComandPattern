using System;

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
            Console.Write("Gib ein Kommando für " + name + " ein: ");

            while ((command = Console.ReadLine()) != "exit")
            {
                switch (command)
                {
                    case "installieren":
                        game.InstallGame();
                        break;
                    case "herunterladen":
                        game.DownloadGame();
                        break;
                    case "aktualisieren":
                        game.UpdateGame();
                        break;
                    case "starten":
                        game.StartGame();
                        break;
                    case "verleihen":
                        Console.Write("Gib den User ein, dem du das Spiel leihen möchtest: ");
                        game.ShareGame(Console.ReadLine());
                        break;
                    case "deinstallieren":
                        game.UnInstallGame();
                        break;
                    case "kaufen":
                        game.BuyGame();
                        break;
                }
                Console.Write("Gib ein Kommando für " + name + " ein: ");
            }
        }
    }
}
