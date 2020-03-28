using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public interface Expression
    {
        /// <summary>
        /// 解释方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Object interpret(String input);
    }
}
