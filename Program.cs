using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);   

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
        }
    }
}