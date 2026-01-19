using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_AC_Back_end_EncapSulation
{
     class BankAC
    {
        private decimal balance;
        public decimal Balance
        {
            get => balance;
            private set => balance = value;
        }
        public void Deposite(decimal amount)
        {
            if(amount<=0)
            {
                throw new Exception("invaild deposite");
            }
            Balance += amount;

        }

        public void Withdrawl(decimal amount)
        {
            if(amount >balance)
            {
                throw new Exception("insufficiant balance");
            }
            
            Balance -=amount;
        }
    }
}
