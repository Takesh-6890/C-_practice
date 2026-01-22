using Mini_App_Payment_Sys_Interface;
namespace Mini_App_Payment_Sys_Interface
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter the payment method");
            Console.WriteLine("1.Google Pay");
            Console.WriteLine("2.PhonePe");

            int choice =int.Parse(Console.ReadLine());
            IPayment payment=null;
            
            switch(choice)
            {
                case 1:payment = new GPay();
                    break;
                case 2:payment = new PhonePy();
                    break;
                default: Console.WriteLine("invalid");
                    break;

            }
            if(payment==null)
            {
                Console.WriteLine("in valid payment method");
                return;
            }
            payment.Pay(500);
            


        }
    }
}
