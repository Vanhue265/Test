using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Abstract_Interface
{
    public class Spider : Animal
    {
        public Spider() : base() { }
        public Spider(int legs) : base(legs) { }
        public override void Eat()
        {
            Console.WriteLine("Spider Eat");
        }
    }
}
