using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban.Presentation
{
    public class GameView
    {

        public void drawMaze(MazeField origin)
        {
            MazeField field = origin;
            while(field.hasSouth())
            {
                while (field.hasEast())
                {
                    Console.Write(field.getCharValue());
                    field = field._east;
                }
                Console.WriteLine();
                origin = origin._south;
                field = origin;
            }            
        }

    }
}