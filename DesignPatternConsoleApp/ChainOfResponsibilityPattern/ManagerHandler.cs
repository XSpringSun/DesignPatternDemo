using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 转发经理
    /// </summary>
    class ManagerHandler : Handler
    {
        public ManagerHandler() : base(EmailType.Manager)
        {
        }

        public override void HandleRequest(EmailType requsetType)
        {
            if (EmailType.Manager == requsetType)
            {
                Console.WriteLine("邮件转到经理处理");
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
