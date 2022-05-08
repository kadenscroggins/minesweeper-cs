namespace minesweeper_cs
{
    internal static class Minesweeper
    {
        const int BeginnerBoardWidth = 27;
        const int BeginnerBoardHeight = 27;
        const int BeginnerMines = 10;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Constants for default game settings
            Tile.sizeMultiplier = 30;
            Tile.positionMultiplier = 30;

            GameWindow gameWindow = new GameWindow();
            int mineCount = BeginnerMines;
            int boardWidth = BeginnerBoardWidth;
            int boardHeight = BeginnerBoardHeight;
            Tile[,] board = new Tile[boardWidth, boardHeight];

            for (int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeight; j++)
                {
                    board[i, j] = new Tile(i, j);
                    gameWindow.AddTile(board[i, j]);
                }
            }

            gameWindow.Size = new Size(Tile.sizeMultiplier * boardWidth + boardWidth,
                Tile.sizeMultiplier * BeginnerBoardHeight + boardHeight + gameWindow.TitlebarHeight());

            Application.Run(gameWindow);
        }
    }
}