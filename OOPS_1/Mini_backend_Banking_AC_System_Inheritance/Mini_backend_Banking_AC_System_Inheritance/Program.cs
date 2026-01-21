using Mini_backend_Banking_AC_System_Inheritance;


class Program
{
    public static void Main()
    {
        Saving_AC sa = new Saving_AC();
        sa.AccountHolder = "takesh";
        sa.Balance = 5000;
        sa.Deposit (1000);
        sa.withdrawl(4000);
        
        

        Current_AC ca=new Current_AC();
        ca.AccountHolder = "Tanvas TEch Solutions";
        ca.Balance = 50000;
        ca.Deposit(9000);
        ca.withdrawl(8000);


    }
}