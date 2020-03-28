using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    class MenuVisitor : Visitor
    {
        public void Visit(Menu menu)
        {
            Console.WriteLine(menu.displayInfo);
        }

        public void Visit(Ingredients ingredients)
        {
            Console.WriteLine(ingredients.displayInfo);
        }
    }
}
