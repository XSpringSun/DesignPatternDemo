using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class LightOnCommand : Command
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.on();
        }
        public void undo() {
            light.off();
        }
    }
}
