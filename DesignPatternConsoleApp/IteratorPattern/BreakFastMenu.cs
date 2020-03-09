using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class BreakFastMenu: Menu
    {
        private List<MenuItme> menuItmes;
        public BreakFastMenu()
        {
            menuItmes = new List<MenuItme>();
            AddItem("梅菜扣肉饼", "好吃", false, 7);
            //菜单项...
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItme menuItme = new MenuItme(name, description, vegetarian, price);
            menuItmes.Add(menuItme);
        }
        public Iterator CreateIterator()
        {
            return new BreakFastIterator(menuItmes);
        }
        //public List<MenuItme> GetMenuItmes()
        //{
        //    return menuItmes;
        //}
    }
}
