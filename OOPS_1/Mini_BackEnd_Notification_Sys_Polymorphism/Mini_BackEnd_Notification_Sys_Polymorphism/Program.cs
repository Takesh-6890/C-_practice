using Mini_BackEnd_Notification_Sys_Polymorphism;
namespace Mini_BackEnd_Notification_Sys_Polymorphism
{
    class Program
    {
        static void Main()
        {
            Notification notifi;
            notifi = new Email();
            notifi.Send();
            notifi = new SMS();
            notifi.Send();


            




        }
    }
}
