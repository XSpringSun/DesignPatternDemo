using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public interface Iterator
    {
        bool HasNext();
        Object Next();
    }
}
