using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 自己处理
    /// </summary>
    class SelfHandler : Handler
    {
        public SelfHandler() : base(EmailType.Self)
        {
        }

        public override void HandleRequest(EmailType requsetType)
        {
            if (EmailType.Self == requsetType)
            {
                Console.WriteLine("邮件由自己处理");
            }
            else
            {
                if (nextHandler != null)
                {
                    nextHandler.HandleRequest(requsetType);
                }
            }
        }
    }
}
