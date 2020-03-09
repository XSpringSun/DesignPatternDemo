using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public  interface Duck
    {
        //叫
        public void Quack();
        //飞
        public void Fly();
    }

    public class GreenDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("绿头鸭，飞");
        }

        public void Quack()
        {
            Console.WriteLine("绿头鸭，呱呱叫");
        }
    }
}
