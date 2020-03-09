using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class SoldState : State
    {
        GumballMachine gumballMachine;
        public SoldState(GumballMachine gumballMachine)
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
