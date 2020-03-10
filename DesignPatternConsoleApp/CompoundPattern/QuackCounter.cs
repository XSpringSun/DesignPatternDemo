using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    public class QuackCounter : Quackable
    {
        Quackable duck;
        private static int numberOfQuacks;
        Observable observable;

        public QuackCounter(Quackable duck)
        {
            this.duck = duck;
            observable = new Observable(duck);
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
            duck.Quack();
            numberOfQuacks++;
            NotifyObservers();
        }

        public static int GetQuacks()
        {
            return numberOfQuacks;
        }
    }
}
