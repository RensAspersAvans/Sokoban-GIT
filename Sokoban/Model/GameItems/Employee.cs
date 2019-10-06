using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model.GameItems
{
    class Employee : Item
    {
        public Employee(MazeField start)
        {
            this.cur_spot = start;
            this.symbol = '~';
            this.awake = true;
        }

        public bool awake { get; set;  }

        public override void wake()
        {
            this.awake = true;
        }
    }
}
