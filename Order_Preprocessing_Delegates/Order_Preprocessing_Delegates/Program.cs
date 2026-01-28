using System;
class Order
{
    public int Quantity { get; set; }
    public int Price { get; set; }
}
class Program
{
    static void Main()
    {
        Predicate<Order> IsvalidOrder=Order=>Order.Quantity >0 && Order.Price >0;

        Func<Order,double> CalTotal=Order=>Order.Quantity*Order.Price;

        Action<string> notify = msg => Console.WriteLine("notification:" + msg);

        Console.WriteLine("enter the quantity of the porduct");
        int quantity=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the price of the each product");
        int price=Convert.ToInt32(Console.ReadLine());  

        Order Myorder = new Order();
        {
            Myorder.Quantity = quantity;
            Myorder.Price = price;
           
            

        }
        if(IsvalidOrder(Myorder))
        {
            double total = CalTotal(Myorder);
            notify($"order placed , total amount {total}");
        }
        else
        {
            notify("invalid order");
        }
    }
}