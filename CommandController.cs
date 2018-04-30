using System;
using System.CodeDom;
using System.Collections.Generic;
using ComandPattern.Commands;
using ComandPattern.Interfaces;

namespace ComandPattern
{
    internal class CommandController : ICommand
    {
        private Game _actualGame;
        private List<State> _stateListForUndo = new List<State>();

        public void Undo()
        {
            throw new NotImplementedException();
        }

        public void InitializeGame(Game game)
        {
            this._actualGame = game;
        }

        public void ExecuteCommand(string command)
        {
            switch (command)
            {
                case "installieren":
                    var install = new InstallCommand(_actualGame);
                    install.Execute();
                    break;
                case "herunterladen":
                    var download = new DownloadCommand(_actualGame);
                    download.Execute();
                    break;
                case "aktualisieren":
                    var update = new UpdateCommand(_actualGame);
                    update.Execute();
                    break;
                case "starten":
                    var start = new StartCommand(_actualGame);
                    start.Execute();
                    break;
                case "verleihen":
                    Console.Write("Gib den User ein, dem du das Spiel leihen möchtest: ");
                    var share = new ShareCommand(_actualGame);
                    share.Execute(Console.ReadLine());
                    break;
                case "deinstallieren":
                    var uninstall = new UninstallCommand(_actualGame);
                    uninstall.Execute();
                    break;
                case "kaufen":
                    var buy = new BuyCommand(_actualGame);
                    buy.Execute();
                    break;
                default:
                    Console.WriteLine("Falscher Befehl.");
                    break;
            }
        }

        public bool CanHandle(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
