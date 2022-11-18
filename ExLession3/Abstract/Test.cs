using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Triangle demo = new Triangle();
            demo.GetArea();
            Console.WriteLine(demo);

            Rectangle demo1 = new Rectangle();
            demo1.GetArea();
            Console.WriteLine(demo1);
        }
    }
}
