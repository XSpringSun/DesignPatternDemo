using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 删除垃圾邮件
    /// </summary>
    class DelHandler : Handler
    {
        public DelHandler() : base(EmailType.Del)
        {
        }

        public override void HandleRequest(EmailType requsetType)
        {
            if (EmailType.Del == requsetType)
            {
                Console.WriteLine("垃圾邮件已删除");
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
