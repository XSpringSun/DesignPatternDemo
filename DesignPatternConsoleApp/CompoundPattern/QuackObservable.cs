using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPattern
{
    public interface QuackObservable
    {
        public void RegisterObserver(Observer observer);
        public void NotifyObservers();
    }
}
