using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        public Handler nextHandler;
        public EmailType type;

        public Handler(EmailType type) {
            this.type = type;
        }

        public void SetNextHandler(Handler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public abstract void HandleRequest(EmailType requsetType);
        
    }
}
