using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze_Model
    {

        public Maze_Model(int number)
        {
            _number = number;
            if (number == 99)
            {
                testMaze();
            }



            //haal string array op
            //loop door alle strings, onthoud de lengte van de grootste
            //buildemptymaze(lengte strings array, grootste string)

        }

        private int _number { get; set; }
        private MazeField _origin { get; set; }

        public void buildEmptyMaze(int lenght, int width)
        {
            _origin = new MazeField();



            for (int y = 0; y < lenght; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (!(x == 0 && y == 0))
                    {
                        MazeField newField = new MazeField();
                        MazeField west = null;
                        MazeField north = null;
                        if (x != 0)
                        {
                            west = _origin;
                            if (y != 0 || x > 1)
                            {
                                for (int i = 0; i < x - 1; i++)
                                {
                                    west = west._east;
                                }
                                for (int k = 0; k < y; k++)
                                {
                                    west = west._south;
                                }
                            }

                            newField._west = west;
                            west._east = newField;
                        }
                        if (y != 0)
                        {
                            if (x == 0)
                            {
                                north = _origin;
                                for (int j = 0; j < y - 1; j++)
                                {
                                    north = north._south;
                                }
                            }
                            else
                            {
                                north = newField._west._north._east;


                            }
                            newField._north = north;
                            north._south = newField;

                        }
                    }
                }
            }
        }

        public void fillMaze()
        {

        }

        public void testMaze()
        {
            buildEmptyMaze(6, 8);
        }
    }
}