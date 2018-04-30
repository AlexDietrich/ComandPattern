using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComandPattern.Interfaces;

namespace ComandPattern.User
{
    internal class User : IUser
    {
        private string Name { get; set; } = string.Empty;
        private List<Game> OwndGames { get; set; } = new List<Game>();
        private List<Game> SharedGames { get; set; } = new List<Game>();

        public User(string name)
        {
            SetName(name);
        }

        public void SetName(string name)
        {
            if (name.Length > 4) this.Name = name;
            else throw new ArgumentException("Der Name ist zu kurz");
        }

        public void AddGame(Game newGame)
        {
            OwndGames.Add(newGame);
        }

        public void ShareGame(Game game, IUser user)
        {
            //TODO: Remove game from List and put it on other users list
        }

        public void RemoveGame(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
