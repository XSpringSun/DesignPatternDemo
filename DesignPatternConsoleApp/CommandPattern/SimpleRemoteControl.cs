using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        //卡槽
        Command slot;

        public void setCommand(Command command)
        {
            slot = command;
        }

        //按下开关
        public void ButtonWasPressed() {
            slot.execute();
        }

    }
}
