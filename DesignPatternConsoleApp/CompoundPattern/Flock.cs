using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    public class Flock : Quackable
    {
        private List<Quackable> quackables = new List<Quackable>();

        public void Add(Quackable quackable)
        {
            quackables.Add(quackable);
        }

        public void Quack()
        {
            var enumerator = quackables.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Quackable quackable = enumerator.Current;
                quackable.Quack();
            }
        }

        public void RegisterObserver(Observer observer)
        {
            foreach (var duck in quackables)
            {
                duck.RegisterObserver(observer); 
            }
        }

        public void NotifyObservers(){}
    }
}
