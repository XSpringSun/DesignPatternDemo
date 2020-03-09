using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeineBeverage coffee = new Coffee();
            CoffeineBeverage tea = new Tea();
            coffee.PrepareRecipe();
            Console.WriteLine("////////////////////////////////");
            tea.PrepareRecipe();
            Console.ReadKey();
        }
    }
}
