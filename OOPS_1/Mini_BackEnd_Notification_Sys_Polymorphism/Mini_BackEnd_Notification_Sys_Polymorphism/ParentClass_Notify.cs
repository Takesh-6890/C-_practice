using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_BackEnd_Notification_Sys_Polymorphism
{
    class Notification
    {
        public virtual void Send()
        {
            Console.WriteLine("sending notification");
        }
    }
}
