using System;
using System.Collections.Generic;
using System.Text;

namespace BuliderPattern
{
    public abstract class AbstractBuilder
    {
        public abstract void BuildDay(int day);
        public abstract void Hotel(string hotel);
        public abstract void Park(string park);
        public abstract void Activity(string activity);
        public abstract void Meal(string meal);
        public abstract Vacation GetVacationPlanner();
    }
}
