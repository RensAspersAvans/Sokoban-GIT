using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class MazeField
    {

        public MazeField _north { get; set; }
        public MazeField _east { get; set; }
        public MazeField _south { get; set; }
        public MazeField _west { get; set; }

        public bool hasSouth()
        {
            if(_south != null)
            {
                return true;
            }
            return false;
        }

        public abstract char getCharValue();
        public bool hasEast()
        {
            if (_east != null)
            {
                return true;
            }
            return false;
        }
        public MazeField findNextField(Directions d)
        {
            if (d == Directions.North)
            {
                return _north;
            }
            else if(d == Directions.East)
            {
                return _east;
            }
            else if(d == Directions.South)
            {
                return _south;
            }
            else if(d == Directions.West)
            {
                return _west;
            }
            else
            {
                return null;
            }
        }

    }
}