using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface Chicken
    {
        //叫
        public void Gobble();
        //飞
        public void Fly();
    }

    public class Hen : Chicken
    {

        public void Gobble()
        {
            Console.WriteLine("母鸡，咯咯叫");
        }

        public void Fly()
        {
            Console.WriteLine("母鸡，飞");
        }

    }
}
