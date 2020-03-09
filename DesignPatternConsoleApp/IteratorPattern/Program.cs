using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //BreakFastMenu breakFastMenu = new BreakFastMenu();

            //List<MenuItme> breakFastMenus = breakFastMenu.GetMenuItmes();

            //DinerMenu dinerMenu = new DinerMenu();
            //MenuItme[] dinerMenus = dinerMenu.GetMenuItmes();
            ////打印早餐
            //for (int i = 0; i < breakFastMenus.Count; i++)
            //{
            //    Console.WriteLine(breakFastMenus[i].Name);
            //}
            ////打印晚餐
            //for (int i = 0; i < dinerMenus.Length; i++)
            //{
            //    Console.WriteLine(dinerMenus[i].Name);
            //}
            //BreakFastMenu breakFastMenu = new BreakFastMenu();

            //Iterator iterator = breakFastMenu.CreateIterator();
            //Console.WriteLine("--------早餐");
            //while (iterator.HasNext()) 
            //{
            //    //取得下一个项
            //    MenuItme menuItme = (MenuItme)iterator.Next();
            //    Console.WriteLine(menuItme.Name);
            //}
            //DinerMenu dinerMenu = new DinerMenu();
            //iterator = dinerMenu.CreateIterator();
            //Console.WriteLine("--------晚餐");
            //while (iterator.HasNext())
            //{
            //    //取得下一个项
            //    MenuItme menuItme = (MenuItme)iterator.Next();
            //    Console.WriteLine(menuItme.Name);
            //}
            BreakFastMenu breakFastMenu = new BreakFastMenu();
            DinerMenu dinerMenu = new DinerMenu();
            new NewMenu(breakFastMenu, dinerMenu).PrintMenu();
            Console.ReadKey();
        }
    }
}
