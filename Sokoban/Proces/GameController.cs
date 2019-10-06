﻿using Sokoban.Model.GameItems;
using Sokoban.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sokoban
{
    public class GameController
    {

        private MenuView _mv;
        private GameView _gv;
        private InputView _iv;
        private Player player;
        private Employee emp;
        public bool running { get; set; }

        public GameController()
        {
            this._mv = new MenuView();
            this._gv = new GameView();
            this._iv = new InputView();
        }

        public void run()
        {
            int levelNumber;
            _mv.show();
            levelNumber = _iv.MenuChoice();
            if(levelNumber == -1)
            {
                //_mv.showExit();
            }
            else
            {
                createMaze(levelNumber);
                Thread.Sleep(2000);
            }
        }

        public Maze _maze_Model {get; set; }
       

        public void getMaze(String input)
        {
            int choice;
            Int32.TryParse(input, out choice);
            _maze_Model = new Maze();
        }


        public Maze createMaze(int choice)
        {
            Maze level;
            MazeCollector parser = new MazeCollector();
            parser.gc = this;
            if(parser.loadFile(choice)) //als de file geladen kan worden
            {
                level = parser.createMaze();
                showMaze(level);
            }
            else
            {
                Console.WriteLine("kan file niet laden");
                level = null;
               // throw new Exception();
            }
            return level;
        }

        public void showMaze(Maze level)
        {
            MazeField origin = level.getMazeFields()[0];
            _gv.drawMaze(origin);           
        }

        public void runGame()
        {
            //aanmaken objecten
            this.running = true;

            while (running)//endgame nog inbouwen
            {
                Console.WriteLine("Press one of the arrow keys to move, or R to reset or S to stop the game.");
                Command c = _iv.setMove();
                if (c == Command.escape || c == Command.restart)
                {
                    //restart of escape
                }
                else
                {
                    switch (c)
                    {
                        
                        case Command.go_north:
                            player.move(Directions.North);
                            break;
                        case Command.go_west:
                            player.move(Directions.West);
                            break;
                        case Command.go_south:
                            player.move(Directions.South);
                            break;
                        case Command.go_east:
                            player.move(Directions.East);
                            break;
                        default:
                            break;
                    }

                    if (emp != null)
                    {
                        emp.update();
                    }
                    
                }
                
            }
        }


    }
}