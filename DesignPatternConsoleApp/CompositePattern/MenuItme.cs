using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class MenuItme : MenuComponent
    {
        string name;
        string decription;
        bool vegetarian;
        double price;

        public MenuItme(string name, string decription, bool vegetarian, double price)
        {
            this.name = name;
            this.decription = decription;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override string GetName()
        {
            return name;
        }
        public override string GetDescription()
        {
            return decription;
        }
        public override double GetPrice()
        {
            return price;
        }
        public override bool IsVegetarian()
        {
            return vegetarian;
        }
        public override void Print()
        {
            Console.Write(" " + GetName());
            if (IsVegetarian())
            {
                Console.Write("V" + GetName());
            }
            Console.WriteLine("，" + GetPrice());
            Console.WriteLine("  --" + GetDescription());
        }
    }
}
