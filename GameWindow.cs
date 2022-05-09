namespace minesweeper_cs
{
    public partial class GameWindow : Form
    {
        internal Tile[,] board;

        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }

        internal void AddTile(Tile tile)
        {
            Controls.Add(tile);
        }

        internal int TitlebarHeight()
        {
            Rectangle screenRectangle = this.RectangleToScreen(this.ClientRectangle);

            int titleHeight = screenRectangle.Top - this.Top;

            return titleHeight;
        }

        protected void ButtonClick(object sender, EventArgs e)
        {
            Tile tile = sender as Tile;
            tile.Text = "!";
            if (tile.mine) tile.Text = "M";
        }

        internal void CreateTiles(int boardWidth, int boardHeight, int mineCount)
        {
            board = new Tile[boardWidth, boardHeight];
            for (int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeight; j++)
                {
                    board[i, j] = new Tile(j, i)
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(0, 0, 0, 0)
                    };
                    board[i, j].Click += new EventHandler(this.ButtonClick);
                    this.mineGrid.Controls.Add(board[i, j]);
                }
            }

            // This section is not finished!
            // Need to make it check if the tile is already a mine, and run again if so.
            // Need to validate the number of mines is less than or equal to amount of tiles on the board
            // Need to verify mines can get placed on every tile
            Random random = new Random((int)DateTimeOffset.Now.ToUnixTimeSeconds());
            for (int i = 0; i < mineCount; i++)
            {
                int x = random.Next(0, boardWidth);
                int y = random.Next(0, boardHeight);
                board[x, y].mine = true;
            }
        }
    }
}