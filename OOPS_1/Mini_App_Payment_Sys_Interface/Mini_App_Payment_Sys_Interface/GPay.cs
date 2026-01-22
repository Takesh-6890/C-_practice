using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_App_Payment_Sys_Interface
{
    class GPay:IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"paymetn done througn gpay{amount}");
        }
    }
}
