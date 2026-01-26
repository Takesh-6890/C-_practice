using System;
using System.Collections.Generic;
using Login_user_order_LINQ_3;
using System.Linq;
namespace Login_user_order_LINQ_3
{
    class Program
    {
        static void Main()
        {
            List<Users> user = new List<Users>
            {
                new Users{id=1,username="Tanvas"},
                new Users{id=2,username="takesh"}
            };
            List<Orders> order = new List<Orders>
            {
                new Orders {orderid=101,userid=1,orderdate=new DateTime(2026,1,15),amount=1500},
                new Orders {orderid=102,userid=2,orderdate=new DateTime(2026,1,19),amount=1500},
                new Orders {orderid=103,userid=1,orderdate=new DateTime(2026,1,11),amount=1500},
                new Orders {orderid=104,userid=2,orderdate=new DateTime(2026,1,13),amount=1500}
            };

            Console.WriteLine("enter username");
            string inputusername = Console.ReadLine();

            var outuser = user.SingleOrDefault(u => u.username.Equals(inputusername, StringComparison.OrdinalIgnoreCase));

            if(user==null)
            {
                Console.WriteLine("user not found");
                return;

            }
            else
            {
                Console.WriteLine("login sucessful");
            }
            var firstorder = order
                .Where(o => o.userid == outuser.id)
                .OrderBy(o => o.orderdate)
                .FirstOrDefault();

            var lastorder = order
                .Where(o => o.userid == outuser.id)
                .OrderBy(o => o.orderdate)
                .LastOrDefault();



            Console.WriteLine("order details");
            

            if(firstorder!=null)
            {
                Console.WriteLine($"--> first order {firstorder.amount} on {firstorder.orderdate.ToShortDateString()}");


            }
            else
            {
                Console.WriteLine($"--> last order {lastorder.amount} on {lastorder.orderdate.ToShortDateString()}");

            }
        }
    }
}