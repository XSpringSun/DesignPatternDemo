using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class NewMenu
    {
        Menu breakFastMenu;
        Menu dinerMenu;
        public NewMenu(Menu breakFastMenu, Menu dinerMenu) {
            this.breakFastMenu = breakFastMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu() {


            Iterator breakFastIterator = breakFastMenu.CreateIterator();
            Console.WriteLine("新菜单--------早餐");
            PrintMenu(breakFastIterator);
            Console.WriteLine("新菜单--------晚餐");
            Iterator dinerIterator = dinerMenu.CreateIterator();
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(Iterator iterator) {
            while (iterator.HasNext())
            {
                //取得下一个项
                MenuItme menuItme = (MenuItme)iterator.Next();
                Console.WriteLine(menuItme.Name);
            }
        }
    }
}
