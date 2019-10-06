using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Presentation
{
    public class InputView
    {

        public void MenuChoiche()
        {
            
        }
        public Command setMove()
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                
                switch (key)
                {
                    case ConsoleKey.R:
                        return Command.restart;
                    case ConsoleKey.S:
                        return Command.escape;
                    case ConsoleKey.UpArrow:
                        return Command.go_north;
                    case ConsoleKey.RightArrow:
                        return Command.go_east;
                    case ConsoleKey.DownArrow:
                        return Command.go_south;
                    case ConsoleKey.LeftArrow:
                        return Command.go_west;

                }

            }
            
        }

        

    }
}
