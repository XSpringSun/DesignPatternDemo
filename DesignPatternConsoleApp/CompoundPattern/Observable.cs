using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    public class Observable : QuackObservable
    {
        //观察者
        List<Observer> observers = new List<Observer>();
        QuackObservable duck;

        public Observable(QuackObservable duck) {
            this.duck = duck;
        }

        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(duck);
            }
        }
    }
}
