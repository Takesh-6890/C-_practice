using Bank_AC_Back_end_EncapSulation;
using System;
class program
{
    static void Main()
    {
        BankAC acc = new BankAC();
        acc.Deposite(100);
        acc.Withdrawl(50);
        Console.WriteLine($"balance {acc.Balance}");
    }
}