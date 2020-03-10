using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    public class QuackObserver : Observer
    {
        public void Update(QuackObservable duck)
        {
            Console.WriteLine("观察者："+duck+" 正在叫");
        }
    }
}
