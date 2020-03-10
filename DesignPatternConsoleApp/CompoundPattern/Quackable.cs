using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    public interface Quackable:QuackObservable
    {
        public void Quack();
    }
}
