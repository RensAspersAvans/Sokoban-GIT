using Sokoban.Model.MazeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sokoban.Model.GameItems;
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

            
            for(int index = 0; index < mazeFile.Length; index++)
            {
                if (level.emptyLevel())
                {
                    mazeLineTop = createLine(mazeFile[index]);
                    level.addLine(mazeLineTop);  
                }
                else
                {
                    mazeLineBottom = createLine(mazeFile[index]);
                    linkVertical(mazeLineTop, mazeLineBottom);
                    level.addLine(mazeLineBottom);
                    mazeLineTop = mazeLineBottom;
                }
                               
                              
            }
                      
            return level;            
        }

        

        private void linkVertical(List<MazeField> listTop, List<MazeField> listBottom)
        {
            int largestIndex; //voor asymetrische doolhoven
            if(listBottom.Count > listTop.Count)
            {
                largestIndex = listBottom.Count;
            }
            else
            {
                largestIndex = listTop.Count;
            }

            for(int index = 0; index < largestIndex; index++)
            {
                if(listBottom[index] != null && listTop[index] != null)
                {
                    listBottom[index]._north = listTop[index];
                    listTop[index]._south = listBottom[index];
                }                
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
                        Player p = new Player(tempField);
                        tempField.content = p;
                        gc.player = p;
                        break;
                    case 'x':                        
                        tempField = new Field_Target();
                        break;
                    case '~':
                        tempField = new Field_Trap();
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