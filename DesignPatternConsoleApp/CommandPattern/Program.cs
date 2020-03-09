using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleRemoteControl remoteControl = new SimpleRemoteControl();
            ////厂商提供的电灯类，命令的接收者
            //Light light = new Light();

            ////我们封装的命令对象，设置接收者
            //LightOnCommand lightOnCommand = new LightOnCommand(light);

            ////设置遥控器开关对应的命令对象
            //remoteControl.setCommand(lightOnCommand);
            //remoteControl.ButtonWasPressed();

            RemoteControl remoteControl = new RemoteControl();
            Light light = new Light();
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            remoteControl.setCommand(0, lightOnCommand, lightOffCommand);
            remoteControl.OnButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(0);
            Console.WriteLine(remoteControl.ToString());
            remoteControl.UndoButtonWasPressed();

            remoteControl.OffButtonWasPressed(0);
            remoteControl.OnButtonWasPressed(0);

            remoteControl.UndoButtonWasPressed();
            Console.ReadKey();
        }
    }
}
