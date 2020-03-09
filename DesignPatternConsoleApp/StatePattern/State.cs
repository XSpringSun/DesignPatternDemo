using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public interface State
    {
        void InsertOneRMB();
        void EjectOneRMB();
        void TurnCrank();
        void Dispense();
    }
}
