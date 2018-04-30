namespace ComandPattern.Interfaces
{
    internal interface IUser
    {
        void SetName(string name);
        void AddGame(Game newGame);
        void ShareGame(Game game, IUser user);
        void RemoveGame(Game game);
    }
}
