using Sokoban.Model.MazeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public class Item //Zelfde idee als MazeField
    {
        public Char symbol { get; set; }
        public MazeField cur_spot { get; set; }


        public void move(Directions d)
        {
            if (checkMove(d))
            {
                this.cur_spot.content = null;
                this.cur_spot = cur_spot.findNextField(d);
                this.cur_spot.content = this;
            }
        }

        public bool checkMove(Directions d)
        {
            if (cur_spot.findNextField(d) is Field_Floor || cur_spot.findNextField(d) is Field_Trap || cur_spot.findNextField(d) is Field_Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
