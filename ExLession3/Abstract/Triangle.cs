using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Triangle : Shape
    {
        public int bot { get; private set; }
        public int height { get; private set; }
        public Triangle() : base() { this.bot = 2; this.height = 3; }
        public Triangle(int bot, int height) { this.bot = bot; this.height = height; }
        public Triangle(string color, int bot, int height) : base(color) { this.bot= bot; this.height = height; }

        public override void GetArea()
        {
            this.area = (this.height * this.bot) / 2;
        }

        public override string ToString()
        {
            return "Triangle --> "
                + "Color: " + this.color + ", "
                + "Height: " + this.height + ", "
                + "Base: " + this.bot + ", "
                + "Area: " + this.area;
        }
    }
}
