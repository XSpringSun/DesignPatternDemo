using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Ingredients : MenuComponent
    {
        public string displayInfo = "不辣，偏咸";
        public void GetState(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
