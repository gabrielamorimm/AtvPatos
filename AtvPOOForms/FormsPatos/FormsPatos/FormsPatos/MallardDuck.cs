using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPatos
{
    public class MallardDuck : Duck, IFlyable, IQuackable, ISwimmable
    {
        public override void display()
        {
            base.display();
        }

        public void swim()
        {
            Console.WriteLine("Nadar");
        }

        public void quack()
        {
            Console.WriteLine("quack");
        }

        public void fly()
        {
            Console.WriteLine("Voar");
        }
    }
}
