using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Test1
    {
        public static void Main(string[] args)
        {
            IMovable a;

            a = new Movablepoint();
            a.MoveLeft();
            Console.WriteLine(a);
        }
    }
}
