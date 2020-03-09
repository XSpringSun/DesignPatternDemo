using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class GumballMachineOld
    {
        static int SOLD_OUT = 0;
        static int NO_ONERMB = 1;
        static int HAS_ONERMB = 2;
        static int SOLD = 3;

        int State = SOLD_OUT;
        int Count = 0;

        public GumballMachineOld(int count)
        {
            this.Count = count;
            if (count > 0)
            {
                State = NO_ONERMB;
            }
        }
        public void InsertOneRMB() {

            if (State == HAS_ONERMB)
            {
                Console.WriteLine("已经投入了，不能再投入");
            }
            else if (State == SOLD_OUT) {
                Console.WriteLine("糖果已经售磐，不能再投入");
            }
            else if (State == SOLD)
            {
                Console.WriteLine("请稍后投入，正在发放糖果");
            }
            else if (State == NO_ONERMB)
            {
                State = HAS_ONERMB;
                Console.WriteLine("你投入了1元钱");
            }
        }
    }
}
