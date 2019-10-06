using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model.GameItems
{
    public class Player : Item
    {
        public Player(MazeField start)
        {
            this.cur_spot = start;
            this.symbol = '@';
        }
    }
}
