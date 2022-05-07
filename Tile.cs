using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper_cs
{
    internal struct Tile
    {
        public static int sizeMultiplier = 1;
        public static int positionMultiplier = 1;
        public bool isMine;
        public int bordering;
        public int posX;
        public int posY;
        public Button button;

        public Tile(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
            isMine = false;
            bordering = 0;
            button = new Button();
            button.Location = new Point(posX * positionMultiplier, posY * positionMultiplier);
            button.Size = new Size(sizeMultiplier, sizeMultiplier);
        }
    }
}
