﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban.Presentation
{
    public class MenuView
    {
        public void show()
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
            Console.Write("|      ");
            Console.WriteLine("~ : valkuil            |                      |");
            Console.Write("|      ");
            Console.WriteLine("$ : collega            |                      |");
            Console.WriteLine("|----------------------------------------------------|");
            Console.WriteLine();           
        }

        public void showEndMenu()
        {
            Console.Clear();
            Console.WriteLine("Gefeliciteerd je hebt het level gehaald!");
            Console.Write("Druk op een knop om af te sluiten ");
            Console.ReadKey();
        }
    }
}