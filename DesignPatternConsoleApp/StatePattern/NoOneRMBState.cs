using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class NoOneRMBState : State
    {
        GumballMachine gumballMachine;
        public NoOneRMBState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
       
        public void InsertOneRMB()
        {
            Console.WriteLine("你投入了1元钱");
            //将糖果状态改到hasOneRMBState
            gumballMachine.SetState(gumballMachine.hasOneRMBState);
        }
        public void EjectOneRMB()
        {
            Console.WriteLine("没有钱可退");
        }

        public void TurnCrank()
        {
            Console.WriteLine("没有钱,不能转动");
        }
        public void Dispense()
        {
            Console.WriteLine("没有钱,不能发放糖果");
        }
    }
}
