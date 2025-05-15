using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPatos
{
    public class TalkingDuck : Duck, IQuackable, IFlyable, ISwimmable, ITalkable
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

        public void falar()
        {
            Console.WriteLine("Falando");
        }
    }
}
