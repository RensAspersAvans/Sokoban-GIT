﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model.MazeTypes
{

    public class Field_Trap : MazeField
    {

        public Field_Trap()
        {
            symbol = '~';
        }

        public override char getCharValue()
        {
            return '~';
        }
    }
}
