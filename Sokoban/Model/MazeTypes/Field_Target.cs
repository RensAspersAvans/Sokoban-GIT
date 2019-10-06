using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban.Model.MazeTypes
{
    public class Field_Target : MazeField
    {
        public Field_Targer()
        {
            this.symbol = 'x';
        }
        public override char getCharValue()
        {
            return 'x';
        }
    }
}