using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_App_Payment_Sys_Interface
{
    class PhonePy:IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"payment done through phonepy{amount}");
        }
    }
}
