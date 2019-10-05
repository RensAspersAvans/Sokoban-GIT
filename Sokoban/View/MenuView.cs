using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class MenuView
    {
        public void showStart()
        {
            Console.WriteLine("|----------------------------------------------------|");
            Console.Write("| ");
            Console.WriteLine("Welkom bij Sokoban                                 |");
            Console.WriteLine("|                                                    |");
            Console.Write("| ");
            Console.Write("Betekenis van symbolen");
            Console.WriteLine("      |   doel van het spel  |");
            Console.WriteLine("|                             |                      |");
            Console.Write("| ");
            Console.WriteLine("spatie : outerspace         |   duw met de truck   |");
            Console.Write("|      ");
            Console.WriteLine("█ : muur               |   de krat(ten)       |");
            Console.Write("|      ");
            Console.WriteLine("· : vloer              |   naar de bestemming |");
            Console.Write("|      ");
            Console.WriteLine("O : krat               |                      |");
            Console.Write("|      ");
            Console.WriteLine("ʘ : krat op bestemming |                      |");
            Console.Write("|      ");
            Console.WriteLine("x : bestemming         |                      |");
            Console.Write("|      ");
            Console.WriteLine("@ : truck              |                      |");
            Console.WriteLine("|----------------------------------------------------|");
            Console.WriteLine();
            
            Console.Write("> Kies een doolhof (1 - 4), s = stop");    //InputView?         
        }
    }
}