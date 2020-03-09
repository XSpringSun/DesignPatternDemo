using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 母鸡适配器
    /// 适配母鸡让它变成鸭子
    /// </summary>
    public class HenAdapter : Duck
    {
        Chicken chicken;
        public HenAdapter(Chicken chicken)
        {
            this.chicken = chicken;
        }
        public void Quack()
        {
            //调用母鸡咯咯叫
            chicken.Gobble();
        }

        public void Fly()
        {
            //调用母鸡飞
            chicken.Fly();
        }

    }
}
