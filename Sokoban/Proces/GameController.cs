using Sokoban.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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

            _mv.show();
        }

        public Maze _maze_Model {get; set; }
       

        public void getMaze(String input)
        {
            int choice;
            Int32.TryParse(input, out choice);
            _maze_Model = new Maze(choice);
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