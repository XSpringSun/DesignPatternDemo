using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class DinerMenu: Menu
    {
        static readonly int Max_Items = 6;
        private int numberOfImtes = 0;
        private MenuItme[] menuItmes;
        public DinerMenu()
        {
            menuItmes = new MenuItme[Max_Items];
            AddItem("爆炒癞蛤蟆", "讲究火候", false, 42);
            //菜单项...
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItme menuItme = new MenuItme(name, description, vegetarian, price);
            if (numberOfImtes >= Max_Items)
            {
                Console.WriteLine("菜单已满");
            }
            else
            {
                menuItmes[numberOfImtes] = menuItme;
                numberOfImtes++;
            }
        }
        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(menuItmes);
        }
        //public MenuItme[] GetMenuItmes()
        //{
        //    return menuItmes;
        //}
    }
}
