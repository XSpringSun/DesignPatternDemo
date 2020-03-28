using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface Visitor
    {
        public void Visit(Menu menu);
        public void Visit(Ingredients ingredients);
    }
}
