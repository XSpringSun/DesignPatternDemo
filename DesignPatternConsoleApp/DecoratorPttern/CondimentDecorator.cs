using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPttern
{
    public abstract class CondimentDecorator:Beverage
    {
    }

    public class Milk : CondimentDecorator{
        //用变量记录被装饰者
        Beverage beverage;
        public Milk(Beverage beverage) {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + "+Milk";
        }
        public override float Cost()
        {
            return beverage.Cost() + 1;
        }
    }

    public class Suger : CondimentDecorator
    {
        //用变量记录被装饰者
        Beverage beverage;
        public Suger(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + "+Suger";
        }
        public override float Cost()
        {
            return beverage.Cost() + 2;
        }
    }
}
