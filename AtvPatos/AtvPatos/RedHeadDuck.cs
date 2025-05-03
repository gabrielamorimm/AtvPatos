using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvPatos
{
    public class RedHeadDuck : Duck, IQuackable, IFlyable, ISwimmable
    {
        public override void display()
        {
            base.display();
        }

        public void fly()
        {
            Console.WriteLine("Voar");
        }

        public void quack()
        {
            Console.WriteLine("QUACK");
        }

        public void swim() 
        { 
            Console.WriteLine("Nadar");
        }
    }
}
