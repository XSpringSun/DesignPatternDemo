using System;

namespace DecoratorPttern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage  beverage  = new DarkRoast();
            Console.WriteLine(beverage.GetDescription());
            Console.WriteLine(beverage.Cost());
            Console.WriteLine("------------------");
            beverage = new Milk(beverage);
            //加牛奶
            Console.WriteLine(beverage.GetDescription());
            Console.WriteLine(beverage.Cost());
            //加牛奶 加糖
            Console.WriteLine("------------------");
            beverage = new Suger(beverage);
            Console.WriteLine(beverage.GetDescription());
            Console.WriteLine(beverage.Cost());
            Console.ReadKey();
        }
    }
}
