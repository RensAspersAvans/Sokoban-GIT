using Sokoban.Model;
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


       

        public abstract char getCharValue();
       

        public Item content { get; set; }

        private Char _Symbol;

        public Char symbol
        {
            get {
                if (content == null)
                {
                    return _Symbol;
                }
                else
                {
                    return content.symbol;
                }

            }

            set{
                _Symbol = value;
            }

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