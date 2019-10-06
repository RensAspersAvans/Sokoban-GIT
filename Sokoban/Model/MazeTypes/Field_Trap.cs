using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model.MazeTypes
{

    public class Field_Trap : MazeField
    {
        public int counter = 3;
        public Field_Trap()
        {
            symbol = '~';
        }

        public override char getCharValue()
        {
            return '~';
        }

        public override Item content
        { get => base.content;
            set {
                base.content = value;
                    counter--;
                if (counter == 0)
                {
                    Field_Empty emptyfield = new Field_Empty();
                    emptyfield._north = _north;
                    emptyfield._south = _south;
                    emptyfield._west = _west;
                    emptyfield._east = _east;
                    _north._south = emptyfield;
                    _south._north = emptyfield;
                    _west._east = emptyfield;
                    _east._west = emptyfield;
                    
                }
            }

        }

    }
}
