using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    public class Goose
    {
        public void Honk() {
            Console.WriteLine("咯咯咯");
        }
    }

    public class GooseAdapter : Quackable
    {
        private Goose goose;
        Observable observable;
        public GooseAdapter(Goose goose) {
            this.goose = goose;
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
            goose.Honk();
            NotifyObservers();
        }
    }
}
