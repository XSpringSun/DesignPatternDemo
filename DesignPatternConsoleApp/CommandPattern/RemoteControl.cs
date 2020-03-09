using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;
        public RemoteControl()
        {
            onCommands = new Command[5];
            offCommands = new Command[5];
            Command noCommand = new NoCommand();
            for (int i = 0; i < 5; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }
        public void setCommand(int slot,Command commandOn, Command commandOff)
        {
            onCommands[slot] = commandOn;
            offCommands[slot] = commandOff;
        }

        //按下开关
        public void OnButtonWasPressed(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }
        //关闭开关
        public void OffButtonWasPressed(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPressed() {
            undoCommand.undo();
        }
        //打印出数组命令对象
        public override string ToString() {
            var sb = new StringBuilder("\n------------Remote Control-----------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append($"[slot{i}] {onCommands[i].GetType()}\t{offCommands[i].GetType()} \n");
            }
            return sb.ToString();
        }

    }
}
