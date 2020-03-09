using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent breakfastMenu = new Menu("早餐菜单", "早餐供应");
            MenuComponent dinnerMenu = new Menu("晚餐菜单", "晚餐供应");
            MenuComponent dessertMenu = new Menu("甜点菜单", "晚餐甜点");

            MenuComponent allMenus = new Menu("ALL MENUS", "all menus combaind");
            //加入菜单
            allMenus.Add(breakfastMenu);
            allMenus.Add(dinnerMenu);
            //加入菜单项
            breakfastMenu.Add(new MenuItme("包子", "鲜肉酱肉", false, 2));
            dinnerMenu.Add(new MenuItme("牛肉拉面", "拉面配牛肉", false, 15));
            dinnerMenu.Add(dessertMenu);
            dessertMenu.Add(new MenuItme("梦龙卷", "切件", false, 16));

            allMenus.Print();

            Console.ReadKey();
        }
    }
}
