using System;

namespace StrategyPattern
{
    //封装叫声行为
    public interface QuackBehavior
    {
       public void quack();
    }

    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("呱呱叫");
        }
    }
    public class Squack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("吱吱叫");
        }
    }
    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("不会叫");
        }
    }
}