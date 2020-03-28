using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Menu : MenuComponent
    {
        public string displayInfo = "不辣，口味适中";
        public void GetState(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
