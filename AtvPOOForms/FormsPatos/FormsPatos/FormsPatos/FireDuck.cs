using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPatos
{
    internal class FireDuck : Duck, IQuackable, IFlyable, IBurnable
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

        public void boladeFogo()
        {
            Console.WriteLine("Tacando bola de fogo");
        }


    }
}
