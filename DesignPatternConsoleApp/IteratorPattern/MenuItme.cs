using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class MenuItme
    {
        //名字
        public string Name { get; set; }
        //描述
        public string Description { get; set; }
        //是否素菜
        public bool Vegetarian { get; set; }
        //价格
        public double Price { get; set; }

        public MenuItme(string name, string description, bool vegetarian, double price) {
            Name = name;
            Description=description;
            Vegetarian = vegetarian;
            Price = price;
        }
    }
}
