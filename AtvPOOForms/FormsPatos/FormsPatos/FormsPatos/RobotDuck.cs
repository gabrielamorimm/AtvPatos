using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPatos
{
    public class RobotDuck : Duck, IFlyable, IQuackable, IProgrammable
    {
        public void quack()
        {
            Console.WriteLine("quack");
        }

        public void fly()
        {
            Console.WriteLine("Voar");
        }

        public void programar()
        {
            Console.WriteLine("Programando");
        }
    }
}
