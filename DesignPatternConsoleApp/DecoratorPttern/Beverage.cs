using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPttern
{
    public abstract class Beverage
    {
        protected string description = "Unkonwn Beverage";
        public virtual string GetDescription()
        {
            return description;
        }
        public abstract float Cost();
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast() {
            description = "深焙咖啡";
        }
        public override float Cost()
        {
            return 1.1f;
        }
    }
}
