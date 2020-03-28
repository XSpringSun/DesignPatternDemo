using System;
using System.Collections.Generic;
using System.Text;

namespace BuliderPattern
{
    public class VacationBuilder : AbstractBuilder
    {
        private Vacation vacation=new Vacation();

        public override void BuildDay(int day)
        {
            vacation.Day = day;
        }

        public override void Hotel(string hotel)
        {
            vacation.Hotel = hotel;
        }
        public override void Activity(string activity)
        {
            vacation.Activity = activity;
        }
        public override void Meal(string meal)
        {
            vacation.Meal = meal;
        }

        public override void Park(string park)
        {
            vacation.Park = park;
        }

        public override Vacation GetVacationPlanner()
        {
            return vacation;
        }
    }
}
