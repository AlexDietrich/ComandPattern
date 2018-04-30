using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandPattern.Commands
{
    internal class InstallCommand
    {
        private Game _game;

        public InstallCommand(Game game)
        {
            _game = game;
        }

        public void Execute()
        {
            _game.InstallGame();
        }
    }
}
