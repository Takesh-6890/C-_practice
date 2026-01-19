using Data_Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Abstraction
{
    interface Payment
    {
        void pay();

    }
}
class upi : Payment
{
    public void pay()
    {
        Console.WriteLine("payment done through upi");
    }
}
    
    

