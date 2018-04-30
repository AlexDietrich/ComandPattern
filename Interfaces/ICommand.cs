namespace ComandPattern.Interfaces
{
    internal interface ICommand
    {
        void Undo();
        void InitializeGame(Game game);
        void ExecuteCommand(string command);
        bool CanHandle(Game game);
    }
}
