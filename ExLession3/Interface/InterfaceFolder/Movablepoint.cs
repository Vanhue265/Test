using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Movablepoint : IMovable
    {
        public int x { get; set; }
        public int y { get; set; }

        public Movablepoint()
        {
            this.x = 0;
            this.y = 0;
        }
        public Movablepoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }



        public void MoveUp()
        {
            y++;
        }
        public void MoveDown()
        {
            y--;
        }
        public void MoveLeft()
        {
            x--;
        }
        public void MoveRight()
        {
            x++;
        }

        public override string ToString()
        {
            return "(" + this.x + "," + this.y + ")";
        }
    }
}
