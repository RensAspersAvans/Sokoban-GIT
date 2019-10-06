using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban.Model.MazeTypes
{
    public class Field_Wall : MazeField
    {
        public Field_Wall()
        {
            this.symbol = '█';
        }

        public override char getCharValue()
        {
            return '█';
        }
    }
}