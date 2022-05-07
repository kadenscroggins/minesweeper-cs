namespace minesweeper_cs
{
    internal static class Minesweeper
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Constants for default game settings
            const int BeginnerBoardWidth = 9;
            const int BeginnerBoardHeight = 9;
            const int BeginnerMines = 10;
            Tile.sizeMultiplier = 30;
            Tile.positionMultiplier = 30;

            GameWindow gameWindow = new GameWindow();
            Tile[,] board = new Tile[BeginnerBoardWidth, BeginnerBoardHeight];
            int mineCount = BeginnerMines;
            int boardWidth = BeginnerBoardWidth;
            int boardHeight = BeginnerBoardHeight;

            for (int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeight; j++)
                {
                    board[i, j] = new Tile(i, j);
                    gameWindow.AddButton(board[i, j].button);
                }
            }

            Application.Run(gameWindow);
        }
    }
}