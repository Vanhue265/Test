using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Rectangle : Shape
    {
        public int width { get; private set; }
        public int length { get; private set; }

        public Rectangle() : base()
        {
            this.width = 2;
            this.length = 3;
        }
        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(string color, bool filled, int width, int length) : base(color)
        {
            this.width = width;
            this.length = length;
        }
        public override void GetArea()
        {
            this.area = this.width * this.length;
        }


        public override string ToString()
        {
            return "Rectangle --> "
                + "Color: " + this.color + ", "

                + "Width: " + this.width + ", "
                + "Length: " + this.length + ", "
                + "Area: " + this.area;

        }
    }
}
