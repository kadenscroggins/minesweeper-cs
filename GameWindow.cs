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
            if (tile.mine) tile.Text = "M";
            else
            {
                this.mineGrid.SuspendLayout();
                this.mineGrid.Controls.Remove(tile);
                this.mineGrid.Controls.Add(new Label()
                {
                    Text = "" + GetBordering(tile.x, tile.y),
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0, 0, 0, 0),
                    Size = new Size(Tile.sizeMultiplier, Tile.sizeMultiplier),
                    TextAlign = ContentAlignment.MiddleCenter
                }, tile.x, tile.y);
                this.mineGrid.ResumeLayout();
            }
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

        internal int GetBordering(int x, int y)
        {
            int mines = 0;
            if (y > 0)
            {
                if (board[y - 1, x].mine) mines++; // Up
            }
            if (y > 0 && x > 0)
            {
                if (board[y - 1, x - 1].mine) mines++; // Up & Left
            }
            if (y > 0 && x < Minesweeper.boardHeight - 1)
            {
                if (board[y - 1, x + 1].mine) mines++; // Up & Right
            }
            if (x > 0)
            {
                if (board[y, x - 1].mine) mines++; // Left
            }
            if (x < Minesweeper.boardHeight - 1)
            {
                if (board[y, x + 1].mine) mines++; // Right
            }
            if (y < Minesweeper.boardWidth - 1)
            {
                if (board[y + 1, x].mine) mines++; // Down
            }
            if (y < Minesweeper.boardWidth - 1 && x > 0)
            {
                if (board[y + 1, x - 1].mine) mines++; // Down & left
            }
            if (y < Minesweeper.boardWidth - 1 && x < Minesweeper.boardHeight - 1)
            {
                if (board[y + 1, x + 1].mine) mines++; // Down & right
            }
            return mines;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Need to make this actually delete the old form, not just hide it
            Minesweeper.StartGame();
        }
    }
}