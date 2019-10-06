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
            this.symbol = '$';
            this.awake = true;
        }

        public bool awake { get; set;  }

        public override char symbol
        {
            get
            {
                if (awake)
                {
                    return '$';
                }
                else
                {
                    return 'Z';
                }
            }
            set => base.symbol = value;
        }

        public override void wake()
        {
            this.awake = true;
        }

        public override bool move(Directions d)
        {
            if (this.cur_spot.findNextField(d).content != null)
            {
                if (this.cur_spot.findNextField(d).content.move(d))
                {
                    base.move(d);
                    return true;
                }
            }
            return false;
        }

        public void update()
        {
            if (awake)
            {
                Random rnd = new Random();
                int i = rnd.Next(1, 4);

                switch (i)
                {
                    case 1:
                    
                        this.move(Directions.North);
                        break;
                    
                    case 2:
                    
                        this.move(Directions.East);
                        break;
                    
                    case 3:
                    
                        this.move(Directions.South);
                       break;
                    
                    case 4:

                        this.move(Directions.West);
                        break;
                    

                    default:
                        break;
                }
            }
            else
            {

            }
        }
    }
}
