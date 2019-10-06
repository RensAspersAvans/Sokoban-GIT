using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model.MazeTypes
{
    class Field_Trap : MazeField
    {


        public override char getCharValue()
        {
            return ' ';
        }
    }
}
