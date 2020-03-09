using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        string name;
        string description;
        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }
        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }
        public override MenuComponent GetChild(int i)
        {
            return menuComponents[i];
        }
        public override string GetName()
        {
            return name;
        }
        public override string GetDescription()
        {
            return description;
        }

        public override void Print()
        {
            Console.Write("\n" + GetName());
            Console.WriteLine("," + GetDescription());
            Console.WriteLine("---------------------");
            foreach (var item in menuComponents)
            {
                item.Print();
            }
        }
    }
}
