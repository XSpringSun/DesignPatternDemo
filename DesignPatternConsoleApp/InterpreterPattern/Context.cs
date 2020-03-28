using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public class Context
    {
        private Expression exp;
        public Context()
        {
            //数据初始化或者对象等
        }
        public void operation(string input)
        {
            //解析语句操作
        }
    }
}
