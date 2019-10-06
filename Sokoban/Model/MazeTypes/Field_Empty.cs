using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Sokoban.Model.MazeTypes
{
    class Field_Empty : MazeField
    {
        public Field_Empty()
        {
            symbol = ' ';
        }
        

        public override char getCharValue()
        {
            return ' ';
        }
    }
}
