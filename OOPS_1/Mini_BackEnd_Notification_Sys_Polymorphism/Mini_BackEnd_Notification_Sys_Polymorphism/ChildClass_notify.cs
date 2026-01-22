using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_BackEnd_Notification_Sys_Polymorphism
{
    class Email:Notification
    {
        public override void Send()
        {
            Console.WriteLine("sending email");
        }
    }
    class SMS:Notification
    {
        public override void Send()
        {
            Console.WriteLine("sending SMS");
        }
    }
}
