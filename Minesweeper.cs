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

            Tile.sizeMultiplier = 30;
            Tile.positionMultiplier = 30;

            GameWindow gameWindow = new();

            int mineCount = BeginnerMines;
            int boardWidth = BeginnerBoardWidth;
            int boardHeight = BeginnerBoardHeight;
            Tile[,] board = new Tile[boardWidth, boardHeight];

            /*TableLayoutPanel mineGrid = new();
            mineGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            mineGrid.Location = new Point(0, 0);
            mineGrid.ColumnCount = boardWidth;
            mineGrid.RowCount = boardHeight;
            mineGrid.Size = gameWindow.Size;*/

            gameWindow.mineGrid.ColumnCount = boardWidth;
            gameWindow.mineGrid.RowCount = boardHeight;
            gameWindow.MaximizeBox = false;

            for (int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeight; j++)
                {
                    board[i, j] = new Tile(i, j);
                    board[i, j].Dock = DockStyle.Fill;
                    board[i, j].Margin = new Padding(0, 0, 0, 0);
                    gameWindow.mineGrid.Controls.Add(board[i, j]);
                    //gameWindow.AddTile(board[i, j]);
                }
            }

            //gameWindow.Size = new Size(Tile.sizeMultiplier * boardWidth + boardWidth,
            //    Tile.sizeMultiplier * BeginnerBoardHeight + boardHeight + gameWindow.TitlebarHeight());

            Application.Run(gameWindow);
        }
    }
}