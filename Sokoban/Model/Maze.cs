using Sokoban.Model.MazeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private int _heigth; //hoeveelheid regels, mag ook y zijn
        private int _width;
        private List<MazeField> _fullMaze; //alle MazeFields
        public Maze()
        {
            _fullMaze = new List<MazeField>();
            _width = 0;
            _heigth = 0;
            _number = 99;
            if (_number == 99)
            {
                testMaze();
            }



            //haal string array op
            //loop door alle strings, onthoud de lengte van de grootste
            //buildemptymaze(lengte strings array, grootste string)

        }

        private int _number { get; set; }
        private MazeField _origin { get; set; } 

       

        public void addLine(List<MazeField> mazeFieldLine)
        {
            if(_heigth == 0)
            {
                _origin = mazeFieldLine[0];
            }

            foreach(MazeField field in mazeFieldLine)
            {
                _fullMaze.Add(field);
            }
            
            

            _heigth++;
        }

        public List<MazeField> getMazeFields()
        {
            return _fullMaze;
        }


        public void fillMaze()
        {

        }

        public void testMaze()
        {
            //buildEmptyMaze(6, 8);
        }

        public int getHeigth()
        {
            return _heigth;
        }
        public void setWidth(int width)
        {
            if (width > _width)
            {
                _width = width;
            }
        }
        public int getWidth()
        {
            return _width;
        }
    }
}