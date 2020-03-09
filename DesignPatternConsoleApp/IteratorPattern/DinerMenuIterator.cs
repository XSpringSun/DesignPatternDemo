using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class DinerMenuIterator : Iterator
    {
        MenuItme[] menuItmes;
        int position = 0;

        public DinerMenuIterator(MenuItme[] menuItmes)
        {
            this.menuItmes = menuItmes;
        }
        public bool HasNext()
        {
            //由于数组是固定长度，不仅要检查数组，还要检查指定位置是否为空，如果为空后面就没有菜单项了
            if (position >= menuItmes.Length || menuItmes[position] == null)
                return false;
            else
                return true;
        }

        public object Next()
        {
            MenuItme menuItme = menuItmes[position];
            position++;
            return menuItme;
        }
    }
}
