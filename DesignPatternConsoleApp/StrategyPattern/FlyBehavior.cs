using System;

namespace StrategyPattern
{
    //封装飞行行为
    public interface FlyBehavior
    {
        public void fly();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("用翅膀飞");
        }
    }
    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("不飞，什么也不做");
        }
    }
}