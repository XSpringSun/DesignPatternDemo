using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class Coffee: CoffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("开水冲泡咖啡");
        }
        public override void AddCondiments()
        {
            Console.WriteLine("加糖和牛奶");
        }
    }
}
