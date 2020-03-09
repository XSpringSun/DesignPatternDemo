using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class NoCommand : Command
    {
        public void execute()
        {
        }
        public void undo()
        {
        }
    }
}
