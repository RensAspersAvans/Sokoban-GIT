using Sokoban.Model.MazeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private int _size; //hoeveelheid regels, mag ook y zijn
        private List<MazeField> _fullMaze; //alle MazeFields
        public Maze()
        {
            _fullMaze = new List<MazeField>();
            _size = 0;
            
            



            //haal string array op
            //loop door alle strings, onthoud de lengte van de grootste
            //buildemptymaze(lengte strings array, grootste string)

        }

        private int _number { get; set; }
        private MazeField _origin { get; set; } 

       

        public void addLine(List<MazeField> mazeFieldLine)
        {
            if(_size == 0)
            {
                _origin = mazeFieldLine[0];
            }

            foreach(MazeField field in mazeFieldLine)
            {
                _fullMaze.Add(field);
            }


            _size++;
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
    }
}