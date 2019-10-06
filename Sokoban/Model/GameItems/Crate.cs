using Sokoban.Model.MazeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model.GameItems
{
    class Crate : Item
    {
        public Crate(MazeField location)
        {
            this.cur_spot = location;
            this.symbol = '#';
        }

        public override MazeField cur_spot
        {
            get
            {
                return base.cur_spot;

            }
            set
            {
                if (value is Field_Empty)
                {
                    this.cur_spot.content = null;
                    this.cur_spot = null;
                    this.check = false;
                }
                else
                {
                    base.cur_spot = value;
                }
            }
        }

        

        public override char symbol {
            get
            {
                if (this.cur_spot is Field_Target)
                {
                    return '0';
                }
                else
                {
                    return '#';
                }
            }
                set => base.symbol = value; }
            


    }
}
