using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    /// <summary>
    /// 有装饰者的工厂
    /// </summary>
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override Quackable CreateReadheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override Quackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
