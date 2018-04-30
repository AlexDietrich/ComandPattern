using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandPattern.Commands
{
    internal class ShareCommand
    {
        private Game _game;

        public ShareCommand(Game game)
        {
            _game = game;
        }

        public void Execute(string user)
        {
            _game.ShareGame(user);
        }
    }
}
