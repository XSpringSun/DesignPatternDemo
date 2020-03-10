using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    /// <summary>
    /// 没有装饰者的工厂
    /// </summary>
    public class DuckFactory : AbstractDuckFactory
    {
        public override Quackable CreateReadheadDuck()
        {
            return new RedheadDuck();
        }

        public override Quackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
