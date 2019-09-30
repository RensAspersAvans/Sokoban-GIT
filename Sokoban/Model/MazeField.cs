using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class MazeField
    {

        public MazeField _north { get; set; }
        public MazeField _east { get; set; }
        public MazeField _south { get; set; }
        public MazeField _west { get; set; }

        public void collide()
        {

        }

    }
}