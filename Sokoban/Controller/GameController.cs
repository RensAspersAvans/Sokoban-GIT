using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class GameController
    {
        public Maze_Model _maze_Model
        {
            get => default;
            set
            {
            }
        }

        public MenuView _menuView
        {
            get => default;
            set
            {
            }
        }

        public GameView _gameView
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