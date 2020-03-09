using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Duck greenHeadDuck = new GreenHeadDuck();
            //greenHeadDuck.display();
            //greenHeadDuck.PerFormQuack();
            //greenHeadDuck.PerFormFly();
            //Console.WriteLine("--------------------------");
            ////橡皮鸭
            //Duck rubberDuck = new RubberDuck();
            //rubberDuck.display();
            //rubberDuck.PerFormQuack();
            //rubberDuck.PerFormFly();

            //绿头鸭
            Duck greenHeadDuck = new GreenHeadDuck();
            greenHeadDuck.display();
            greenHeadDuck.SetQuackBehavior(new Quack());
            greenHeadDuck.PerFormQuack();
            //让它闭嘴
            greenHeadDuck.SetQuackBehavior(new MuteQuack());
            greenHeadDuck.PerFormQuack();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// 鸭子超类
    /// </summary>
    public abstract class Duck {

        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public void swin() { }
        public abstract void display();

        public void SetFlyBehavior(FlyBehavior flyBehavior) {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(QuackBehavior quackBehavior) {
            this.quackBehavior = quackBehavior;
        }
        public void PerFormFly()
        {
            flyBehavior.fly();
        }
        public void PerFormQuack()
        {
            quackBehavior.quack();
        }
    }

    /// <summary>
    /// 绿头鸭
    /// </summary>
    public class GreenHeadDuck : Duck
    {
        public GreenHeadDuck() {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("绿头鸭,我的头顶有一片草原(*^_^*)");
        }
    }

    /// <summary>
    /// 橡皮鸭
    /// </summary>
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squack();
        }
        public override void display()
        {
            Console.WriteLine("橡皮鸭");
        }
    }



}
