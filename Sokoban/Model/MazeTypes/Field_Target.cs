﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban.Model.MazeTypes
{
    public class Field_Target : MazeField
    {

        public override char getCharValue()
        {
            return 'x';
        }
    }
}