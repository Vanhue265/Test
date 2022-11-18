using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Abstract_Interface
{
    public class Cat : Animal, IPet
    {
        public string name { get; set; }
        public Cat() : base() { this.name = "Unknown"; }
        public Cat(string name)
        {
            this.name = name;
        }
        public Cat(int legs, string name) : base(legs) { this.name = name; }

        public void Play()
        {
            Console.WriteLine("Cat Play");
        }
        public override void Eat()
        {
            Console.WriteLine("Cat Eat");
        }

    }
  
}
