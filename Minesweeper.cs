namespace minesweeper_cs
{
    internal static class Minesweeper
    {
        // Constants for default game settings
        const int BeginnerBoardWidth = 9;
        const int BeginnerBoardHeight = 9;
        const int BeginnerMines = 10;

        // Settings. Need to move to a config file.
        static int mineCount;
        static int boardWidth;
        static int boardHeight;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Tile.sizeMultiplier = 30;
            Tile.positionMultiplier = 30;
            SetDifficulty(BeginnerMines, BeginnerBoardWidth, BeginnerBoardHeight);
            StartGame();
        }
        static void StartGame()
        {
            // Create form and adjust its settings
            GameWindow gameWindow = new();
            gameWindow.mineGrid.ColumnCount = boardWidth;
            gameWindow.mineGrid.RowCount = boardHeight;
            gameWindow.MaximizeBox = false;

            // Create board and place tiles on it
            gameWindow.CreateTiles(boardWidth, boardHeight);

            Application.Run(gameWindow);
        }

        static void SetDifficulty(int mineCount, int boardWidth, int boardHeight)
        {
            Minesweeper.mineCount = mineCount;
            Minesweeper.boardWidth = boardWidth;
            Minesweeper.boardHeight = boardHeight;
        }
    }
}