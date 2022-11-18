using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Abstract_Interface
{
    public class Fish : Animal, IPet
    {
        public string name { get; set; }
        public Fish() : base() { this.name = "Unknown Fish"; }
        public Fish(string name)
        {
            this.name = name;
        }
        public Fish(int legs, string name) : base(legs) { this.name = name; }

        public void Play()
        {
            Console.WriteLine("Fish Play");
        }
        public override void Eat()
        {
            Console.WriteLine("Fish Eat");
        }
        public override void Walk()
        {
            Console.WriteLine("Swim");
        }
    }
}
