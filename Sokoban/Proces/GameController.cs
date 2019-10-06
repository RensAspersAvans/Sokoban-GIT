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
                Thread.Sleep(20000);
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
            MazeField origin = level._origin._south._south;
            int mazeHeight = level.getHeigth();
            int mazeWidth = level.getWidth();
            Console.Clear();
            _gv.drawMaze(origin, mazeHeight, mazeWidth);           
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
                    //playerobject.move(c)
                    //if er een medewerker is, update die
                }
                
            }
        }


    }
}