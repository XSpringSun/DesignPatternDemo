using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    /// <summary>
    /// 定义抽象工厂，由子类创建不同的家族
    /// </summary>
    public abstract class AbstractDuckFactory
    {
        public abstract Quackable CreateReadheadDuck();
        public abstract Quackable CreateRubberDuck();
    }
}
