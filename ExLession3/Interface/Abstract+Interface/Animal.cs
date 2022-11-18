using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Abstract_Interface
{
    public abstract class Animal
    {
        public int legs { get; private set; }
        protected Animal() { this.legs = 0; }
        protected Animal(int legs)
        {
            this.legs = legs;
        }

        public virtual void Walk()
        {
            Console.WriteLine("Walk");
        }
        public abstract void Eat();
    }
}
