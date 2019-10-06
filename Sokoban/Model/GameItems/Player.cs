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

        public override bool move(Directions d)
        {
            if (this.cur_spot.findNextField(d).content != null)
            {
                if (this.cur_spot.findNextField(d).content is Crate)
                {
                    if (this.cur_spot.findNextField(d).content.move(d))
                    {
                        this.cur_spot.content = null;
                        this.cur_spot = cur_spot.findNextField(d);
                        this.cur_spot.content = this;
                        return true;
                    }
                }
               
                else if (this.cur_spot.findNextField(d).content is Employee)
                {
                    this.cur_spot.findNextField(d).content.wake();
                }
                return false;
            }

            if (checkMove(d))
            {
                this.cur_spot.content = null;
                this.cur_spot = cur_spot.findNextField(d);
                this.cur_spot.content = this;
                return true;
            }
            return false;

        }
    }
}
