using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class GumballMachine
    {
        public State soldOutState { get; }
        public State noOneRMBState { get; }
        public State hasOneRMBState { get; }
        public State soldState { get; }


        State State;
        int Count = 0;

        public GumballMachine(int count)
        {
            this.Count = count;
            soldOutState = new SoldOutState(this);
            noOneRMBState = new NoOneRMBState(this);
            hasOneRMBState = new HasOneRMBState(this);
            soldState = new SoldState(this);
            if (count > 0)
            {
                State = noOneRMBState;
            }
            else {
                State = soldOutState;
            }
        }
        /// <summary>
        /// 投入1元
        /// </summary>
        public void InsertOneRMB()
        {
            State.InsertOneRMB();
        }
        /// <summary>
        /// 退回1元
        /// </summary>
        public void EjectOneRMB() {
            State.EjectOneRMB();
        }

        /// <summary>
        /// 转动手柄
        /// </summary>
        public void TurnCrank() {
            State.TurnCrank();
            //状态内部动作，所以我们不在需要单独一个发放糖果的方法。
            State.Dispense();
        }

        /// <summary>
        /// 设置状态
        /// </summary>
        /// <param name="state"></param>
        public void SetState(State state)
        {
            this.State = state;
        }
    }
}
