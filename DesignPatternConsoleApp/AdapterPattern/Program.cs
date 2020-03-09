using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GreenDuck duck = new GreenDuck();
            duck.Quack();
            duck.Fly();

            Console.WriteLine("-----母鸡适配器--------");
            Duck henAdapter = new HenAdapter(new Hen());
            henAdapter.Quack();
            henAdapter.Fly();

            Console.ReadKey();
        }
    }
}
