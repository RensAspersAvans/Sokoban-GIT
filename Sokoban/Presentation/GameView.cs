using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban.Presentation
{
    public class GameView
    {

        public void drawMaze(MazeField origin, int mazeHeight, int mazeWidth)
        {
            MazeField field = origin;
            for(int y = 0; y < mazeHeight; y++)
            {
                for(int x = 0; x < mazeWidth; x++)
                {
                    try
                    {
                        Console.Write(field.symbol);
                        field = field._east;
                    }
                    catch
                    {
                        Console.Write(' ');
                        break;
                    }       
                    
                }
                Console.WriteLine();
                
                origin = origin._south;
                field = origin;

            }
           
        }

    }
}