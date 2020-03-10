using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    public class RedheadDuck : Quackable
    {
        Observable observable;
        public RedheadDuck() {
            observable = new Observable(this);
        }
        public void RegisterObserver(Observer observer)
        {
            observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("呱呱呱");
            NotifyObservers();
        }
    }
}
