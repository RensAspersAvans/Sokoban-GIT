using Sokoban.Model.MazeTypes;
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

            
            for(int index = 0; index < mazeFile.Length - 1; index++)
            {
                mazeLineTop = createLine(mazeFile[index]);
                mazeLineBottom = createLine(mazeFile[index + 1]);
                linkVertical();                
                level.addLine(mazeLineTop);                
            }
                  
                       
            return level;            
        }

        

        private void linkVertical()
        {
            int largestIndex; //voor asymetrische doolhoven
            if(mazeLineBottom.Count > mazeLineTop.Count)
            {
                largestIndex = mazeLineBottom.Count;
            }
            else
            {
                largestIndex = mazeLineTop.Count;
            }

            for(int index = 0; index < largestIndex; index++)
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