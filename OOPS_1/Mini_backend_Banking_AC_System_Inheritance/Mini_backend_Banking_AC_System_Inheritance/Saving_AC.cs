using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_backend_Banking_AC_System_Inheritance
{
    //child class 1
    class Saving_AC : Banking_AC
    {
        public override void withdrawl(double Amount)
        {
            if (Balance-Amount<100)
            {
                Console.WriteLine("minimum balance should be 1000");
            }
            else
            {
                Balance -= Amount;
                Console.WriteLine("withdrawn from Saving Account" +Amount);
                Console.WriteLine("available balance "+Balance);
            }

        }
    }

}
    

