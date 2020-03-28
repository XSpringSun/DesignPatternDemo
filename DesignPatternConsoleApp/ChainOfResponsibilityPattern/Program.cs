using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //组装责任链
            Handler handler = new SelfHandler();
            Handler handler1 = new ManagerHandler();
            Handler handler2 = new DelHandler();
            handler.SetNextHandler(handler1);
            handler1.SetNextHandler(handler2);
            //测试
            handler.HandleRequest(EmailType.Del);
            handler.HandleRequest(EmailType.Manager);
            handler.HandleRequest(EmailType.Self);

            Console.ReadKey();
        }
    }
}
