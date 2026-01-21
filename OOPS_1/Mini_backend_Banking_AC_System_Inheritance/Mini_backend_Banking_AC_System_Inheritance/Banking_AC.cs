using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_backend_Banking_AC_System_Inheritance
{
    //parent class
    class Banking_AC
    {
        public string AccountHolder;
        public double Balance;
        public void Deposit(double Amount)
        {
            Balance += Amount;
            Console.WriteLine("deposited amount" +Amount);
        }
        public virtual void withdrawl(double Amount)
        {
            Balance -= Amount;
            Console.WriteLine("withdrawn ammount "+ Amount);
        }

    }
}
