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
            MessageBox.Show("Position - X: " + tile.x + " Y: " + tile.y);
        }

        internal void CreateTiles(int width, int height)
        {
            board = new Tile[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
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
        }
    }
}