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

        public override char symbol {
            get
            {
                if (this.cur_spot is Field_Target)
                {
                    return 'X';
                }
                else
                {
                    return '#';
                }
            }
                set => base.symbol = value; }
            


    }
}
