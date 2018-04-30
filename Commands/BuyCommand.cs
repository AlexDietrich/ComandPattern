using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandPattern.Commands
{
    internal class BuyCommand
    {
        private Game _game;

        public BuyCommand(Game game)
        {
            _game = game;
        }

        public void Execute()
        {
            _game.BuyGame();
        }
    }
}
