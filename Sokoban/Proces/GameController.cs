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

        public Maze _maze_Model
        {
            get => default;
            set
            {
            }
        }


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
            MazeField origin = level.getMazeFields()[0];
            _gv.drawMaze(origin);           
        }


    }
}