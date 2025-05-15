using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPatos
{
    public class RubberDuck : Duck, IQuackable, ISwimmable
    {
        public override void display()
        {
            base.display();
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
