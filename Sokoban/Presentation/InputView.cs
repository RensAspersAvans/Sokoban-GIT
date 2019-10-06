using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Presentation
{
    public class InputView
    {

        public int MenuChoice()
        {
            Console.Write("> Kies een doolhof (1 - 6), s = stop");
            int choice = -1;

            ConsoleKeyInfo input = Console.ReadKey();
            while(true)
            {
                if(input.KeyChar >= '1' && input.KeyChar <= '4')
                {
                    choice = (int)char.GetNumericValue(input.KeyChar);
                    return choice;
                }
                if(input.KeyChar == 's')
                {
                    return -1;
                }
                Console.WriteLine("Probeer opnieuw.");
                input = Console.ReadKey();
            }
            
        }
        public void setMove()
        {
            ConsoleKey keyPressed;
            
        }

        

    }
}
