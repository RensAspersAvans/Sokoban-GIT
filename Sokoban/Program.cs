using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Program
    {
        public GameController GameController
        {
            get => default;
            set
            {
            }
        }

        static void Main(string[] args)
        {
            new GameController().run();
        }
    }
}
