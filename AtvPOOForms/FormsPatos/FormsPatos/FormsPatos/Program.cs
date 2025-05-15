using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPatos
{
    internal static class Program
    {
        static void Main()
        {
            RedHeadDuck redheadduck = new RedHeadDuck();
            Console.WriteLine("PATO DE CABEÇA VERMELHA FAZ:");
            redheadduck.display();
            redheadduck.quack();
            redheadduck.swim();
            redheadduck.fly();

            MallardDuck mallardduck = new MallardDuck();
            Console.WriteLine("PATO MALLARD FAZ:");
            mallardduck.display();
            mallardduck.quack();
            mallardduck.swim();
            mallardduck.fly();

            RubberDuck rubberduck = new RubberDuck();
            Console.WriteLine("PATO DE BORRACHA FAZ:");
            rubberduck.display();
            rubberduck.quack();
            rubberduck.swim();

            FireDuck fireduck = new FireDuck();
            Console.WriteLine("PATO DE FOGO FAZ:");
            fireduck.display();
            fireduck.quack();
            fireduck.boladeFogo();
            fireduck.fly();


            RobotDuck robotDuck = new RobotDuck();
            Console.WriteLine("PATO ROBÔ FAZ:");
            robotDuck.display();
            robotDuck.quack();
            robotDuck.programar();
            robotDuck.fly();

 
            TalkingDuck talkingDuck = new TalkingDuck();
            Console.WriteLine("PATO FALANTE FAZ:");
            talkingDuck.display();
            talkingDuck.quack();
            talkingDuck.falar();
            talkingDuck.fly();
        }
    }
}
