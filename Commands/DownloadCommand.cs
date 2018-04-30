using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandPattern.Commands
{
    internal class DownloadCommand
    {
        private Game _game;

        public DownloadCommand(Game game)
        {
            _game = game;
        }

        public void Execute()
        {
            _game.DownloadGame();
        }
    }
}
