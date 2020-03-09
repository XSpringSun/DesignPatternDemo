using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public interface Command
    {
        //执行命令的方法
        public void execute();
        //撤销命令方法
        public void undo();
    }
}
