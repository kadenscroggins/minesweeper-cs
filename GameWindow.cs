namespace minesweeper_cs
{
    public partial class GameWindow : Form
    {
        internal Tile[,]? board;

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

            Random random = new((int)DateTimeOffset.Now.ToUnixTimeSeconds());
            for (int i = 0; i < mineCount; i++)
            {
                if (mineCount > (boardWidth * boardHeight)) mineCount = (boardWidth * boardHeight);
                int x = random.Next(0, boardWidth);
                int y = random.Next(0, boardHeight);
                if (!board[x, y].mine) board[x, y].mine = true;
                else i--;
            }
        }
    }
}