using System;

namespace CompoundPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            Simulator(duckFactory);
            Console.ReadKey();
        }

        static void Simulator(AbstractDuckFactory duckFactory) {
            Quackable redheadDuck = duckFactory.CreateReadheadDuck();
            Quackable rubberDuck = duckFactory.CreateRubberDuck();
            Quackable gooseDuck = new GooseAdapter(new Goose());
            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            QuackObserver observer = new QuackObserver();
            flockOfDucks.RegisterObserver(observer);

            Console.WriteLine("模拟器");
            Simulator(flockOfDucks);
            Console.WriteLine("鸭子叫声：" + QuackCounter.GetQuacks());
        }

        static void Simulator(Quackable duck) {
            duck.Quack();
        }
    }
}
