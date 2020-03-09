using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Light
    {
        public void on() {
            Console.WriteLine("打开电灯");
        }

        public void off()
        {
            Console.WriteLine("关闭电灯");
        }
    }
}
