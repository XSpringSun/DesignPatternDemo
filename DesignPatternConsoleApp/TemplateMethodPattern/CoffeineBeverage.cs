using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class CoffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public abstract void AddCondiments();
        public abstract void Brew();

        private void BoilWater()
        {
            Console.WriteLine("烧开水");
        }

        private void PourInCup()
        {
            Console.WriteLine("茶到进杯子");
        }
    }
}
