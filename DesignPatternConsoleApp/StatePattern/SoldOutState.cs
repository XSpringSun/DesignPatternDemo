using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class SoldOutState : State
    {
        GumballMachine gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            throw new NotImplementedException();
        }

        public void EjectOneRMB()
        {
            throw new NotImplementedException();
        }

        public void InsertOneRMB()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
