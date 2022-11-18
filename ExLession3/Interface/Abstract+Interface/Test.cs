using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Abstract_Interface
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Fish d = new Fish();
            d.Walk();
            d.Play();
            d.Eat();

            Cat c = new Cat("Fluffy");
            c.Walk();
            c.Play();
            c.Eat();

            Animal a = new Fish();
            a.Walk();
            a.Eat();

            Animal e = new Spider();
            e.Walk();
            e.Eat();

            IPet p = new Cat();
            p.Play();

        }
    }
}
