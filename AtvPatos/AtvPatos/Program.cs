namespace AtvPatos
{
    public class Program
    {
        static void Main(string[] args)
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

        }
    }
}
