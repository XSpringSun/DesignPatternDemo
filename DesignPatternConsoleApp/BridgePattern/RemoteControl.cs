using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class RemoteControl
    {
        public TV tv;
        public void SetTV(TV tv) {
            this.tv = tv;
        }

        public abstract void SetChannel();
    }
}
