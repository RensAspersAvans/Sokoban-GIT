using Sokoban.Model.GameItems;
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
        private bool _finished;
        public Maze()
        {
            _fullMaze = new List<MazeField>();
            _width = 0;
            _heigth = 0;
            _finished = false;
        }

        private int _number { get; set; }
        public MazeField _origin { get; set; }

        public bool checkFinished()
        {
            int amountOfCrates = 0;
            int amountOfTargetsWithCrates = 0;
            foreach(MazeField field in _fullMaze)
            {
                if(field.content is Crate)
                {
                    amountOfCrates++;
                }
                if(field is Field_Target && field.content is Crate)
                {
                    amountOfTargetsWithCrates++;
                }
            }
            if(amountOfCrates == amountOfTargetsWithCrates)
            {
                _finished = true;
                
            }
            return _finished;
        }

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

        public bool emptyLevel()
        {
            if (_fullMaze.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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