using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface MenuComponent
    {
        public void GetState(Visitor visitor);
    }
}
