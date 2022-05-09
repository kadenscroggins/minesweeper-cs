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
            Tile[,] board = new Tile[boardWidth, boardHeight];
            for (int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeight; j++)
                {
                    board[i, j] = new Tile
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(0, 0, 0, 0)
                    };
                    gameWindow.mineGrid.Controls.Add(board[i, j]);
                }
            }

            Application.Run(gameWindow);
        }
    }
}