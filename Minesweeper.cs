namespace minesweeper_cs
{
    internal static class Minesweeper
    {
        // Constants for default game settings
        const int BeginnerBoardWidth = 9;
        const int BeginnerBoardHeight = 9;
        const int BeginnerMines = 10;

        // Settings. Need to move to a config file.
        internal static int mineCount;
        internal static int boardWidth;
        internal static int boardHeight;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Tile.sizeMultiplier = 30;
            Tile.positionMultiplier = 30;
            SetDifficulty(BeginnerBoardWidth, BeginnerBoardHeight, BeginnerMines);
            StartGame();
        }
        public static void StartGame()
        {
            // Create form and adjust its settings
            GameWindow gameWindow = new();
            gameWindow.mineGrid.ColumnCount = boardWidth;
            gameWindow.mineGrid.RowCount = boardHeight;
            gameWindow.MaximizeBox = false;

            // Create board and place tiles on it
            gameWindow.CreateTiles(boardWidth, boardHeight, mineCount);

            gameWindow.ShowDialog();
            //Application.Run(gameWindow);
        }

        static void SetDifficulty(int boardWidth, int boardHeight, int mineCount)
        {
            Minesweeper.mineCount = mineCount;
            Minesweeper.boardWidth = boardWidth;
            Minesweeper.boardHeight = boardHeight;
        }
    }
}