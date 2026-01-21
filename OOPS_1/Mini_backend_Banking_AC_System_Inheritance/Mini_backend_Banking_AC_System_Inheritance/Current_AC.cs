using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_backend_Banking_AC_System_Inheritance
{
    //child class 2
    class Current_AC : Banking_AC
    {
        public override void withdrawl(double Amount)
        {
            Balance -= Amount;
            Console.WriteLine("withdrawn from Current Account" +Amount);
            Console.WriteLine("available balance " + Balance);
        }
    }
}
