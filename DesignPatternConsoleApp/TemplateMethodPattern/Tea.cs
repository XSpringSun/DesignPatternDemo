using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class Tea : CoffeineBeverage
    {
        public override bool CustomerWantsCondiments()
        {
            return false;
        }
        public override void Brew()
        {
            Console.WriteLine("开水浸泡茶");
        }
        public override void AddCondiments()
        {
            Console.WriteLine("加柠檬");
        }

    }
}
