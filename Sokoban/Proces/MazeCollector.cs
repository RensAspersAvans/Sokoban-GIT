﻿using Sokoban.Model.MazeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sokoban.Model.GameItems;
using Sokoban.Model.MazeTypes;
using System.Threading;

namespace Sokoban
{
    public class MazeCollector //Uitlezen doolhofbestand (uit Sokoban.MazeFiles) + Maze aanmaken (Heet Parser in Slides)
    {
       private string[] mazeFile;
       private List<MazeField> mazeLineTop = new List<MazeField>();
       private List<MazeField> mazeLineBottom = new List<MazeField>();
       private Maze level;
       public GameController gc { get; set; }
       public bool loadFile(int choice) //laad de file en returnt true als het succesvol is, anders false
       {
            try
            {
                mazeFile = System.IO.File.ReadAllLines(@"..\\..\\MazeFiles\\maze" + choice + ".txt");
            }
            catch
            {
                return false;
            }
            return true;
       }



        public Maze createMaze()
        {
            level = new Maze();

            int height = 0;
            foreach(string line in mazeFile)
            {
                if(height % 2 == 0)
                {
                    mazeLineTop = createLine(line);
                }
                else
                {
                    mazeLineBottom = createLine(line);
                    linkVertical();
                    level.addLine(mazeLineTop);
                    level.addLine(mazeLineBottom);
                }
                height++;
            }

            if(height%2==1) //oneven aantal regels
            {
                List<MazeField> tempList = new List<MazeField>();
                tempList = mazeLineBottom;
                mazeLineBottom = mazeLineTop;
                mazeLineTop = tempList;
                linkVertical();
                level.addLine(mazeLineBottom);
            }
            
                       
            return level;            
        }

        

        private void linkVertical()
        {
            int smallestIndex; //voor asymetrische doolhoven
            if(mazeLineBottom.Count < mazeLineTop.Count)
            {
                smallestIndex = mazeLineBottom.Count;
            }
            else
            {
                smallestIndex = mazeLineTop.Count;
            }

            for(int index = 0; index < smallestIndex; index++)
            {
                mazeLineBottom[index]._north = mazeLineTop[index];
                mazeLineTop[index]._south = mazeLineBottom[index];
            }
            
        }

       

        private List<MazeField> createLine(string line)
        {
            List<MazeField> mazeLine = new List<MazeField>();
            int width = 0;
            foreach (char field in line)
            {
                MazeField tempField;
                switch(field)
                {
                    case '#':                        
                        tempField = new Field_Wall();
                        break;
                    case 'o':                        
                        tempField = new Field_Floor();
                        tempField.content = new Crate(tempField);
                        break;
                    case '.':                        
                        tempField = new Field_Floor();
                        break;
                    case '@':                        
                        tempField = new Field_Floor();
                        tempField.content = new Player(tempField);
                        break;
                    case 'x':                        
                        tempField = new Field_Target();
                        break;
                    default:
                        tempField = new Field_Empty();
                        break;
                }
                width++;
                mazeLine.Add(tempField);
            }
            level.setWidth(width);
            
            //Link Horizontal
            for (int index  = 0; index < mazeLine.Count; index++)
            {
                if(index != 0)
                {
                    mazeLine[index]._west = mazeLine[index - 1];
                }
                if(index < mazeLine.Count - 1)
                {
                    mazeLine[index]._east = mazeLine[index + 1];
                }                
            }

            return mazeLine;
        }
    }
}