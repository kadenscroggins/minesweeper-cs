using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper_cs
{
    internal class Tile : Button
    {
        public static int sizeMultiplier = 1;
        public static int positionMultiplier = 1;

        public bool mine;
        public bool flagged;
        public int bordering;
        public int x;
        public int y;

        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
            mine = false;
            flagged = false;
            bordering = 0;
            base.Size = new Size(sizeMultiplier, sizeMultiplier);
        }
    }
}
