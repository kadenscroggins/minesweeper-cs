namespace minesweeper_cs
{
    internal static class Minesweeper
    {
        // Constants for default game settings
        const int BeginnerBoardWidth = 9;
        const int BeginnerBoardHeight = 9;
        const int BeginnerMines = 10;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            StartGame();
        }
        static void StartGame()
        {
            // Settings. Need to move to a config file.
            Tile.sizeMultiplier = 30;
            Tile.positionMultiplier = 30;
            int mineCount = BeginnerMines;
            int boardWidth = BeginnerBoardWidth;
            int boardHeight = BeginnerBoardHeight;

            // Create form and adjust its settings
            GameWindow gameWindow = new();
            gameWindow.mineGrid.ColumnCount = boardWidth;
            gameWindow.mineGrid.RowCount = boardHeight;
            gameWindow.MaximizeBox = false;

            // Create board and place tiles on it
            gameWindow.CreateTiles(boardWidth, boardHeight);

            Application.Run(gameWindow);
        }
    }
}