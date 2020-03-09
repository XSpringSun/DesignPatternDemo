using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class BreakFastIterator: Iterator
    {
        List<MenuItme> menuItmes;
        int position = 0;

        public BreakFastIterator(List<MenuItme> menuItmes)
        {
            this.menuItmes = menuItmes;
        }
        public bool HasNext()
        {
            if (position >= menuItmes.Count)
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
