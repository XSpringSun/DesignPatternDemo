using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Ingredients ingredients = new Ingredients();

            MenuVisitor visitor = new MenuVisitor();
            visitor.Visit(menu);
            visitor.Visit(ingredients);
            Console.ReadKey();
        }
    }
}
