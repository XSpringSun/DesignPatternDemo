using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class ConcreteRemote : RemoteControl
    {
        public override void SetChannel()
        {
            this.tv.TuneChannel();
        }
    }
}
