using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Shape
    {
        public string color { get; private set; }
        public double area { get; set; }
        public Shape()
        {
            this.color = "Red";
        }
        public Shape(string color)
        {
            this.color = color;
        }

        public abstract void GetArea();

        public override string ToString()
        {
            return "Shape --> "
                + "Color: " + this.color + ", "
                + "Area: " + this.area;
        }
    }
}
