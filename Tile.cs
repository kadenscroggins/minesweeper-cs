using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper_cs
{
    internal struct Tile
    {
        public bool isMine;
        public int bordering;
        
        public Tile()
        {
            isMine = false;
            bordering = 0;
        }
    }
}
