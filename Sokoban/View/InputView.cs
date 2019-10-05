using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.View
{
    class InputView
    {
        String _input;

        public string askString()
        {
            _input = Console.ReadLine();
            return _input;
        }
        
       


    }
}
