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
        

        public GameController()
        {
            this._mv = new MenuView();
            this._gv = new GameView();
        }

        public void run()
        {

            _mv.show();
        }

        public Maze_Model _maze_Model
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
            _maze_Model = new Maze_Model(choice);
        }


    }
}