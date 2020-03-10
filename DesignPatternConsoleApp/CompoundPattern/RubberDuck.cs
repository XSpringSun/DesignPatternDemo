using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    public class RubberDuck : Quackable
    {
        Observable observable;
        public RubberDuck()
        {
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
            //橡皮鸭的叫声
            Console.WriteLine("吱吱吱");
            NotifyObservers();
        }
    }
}
