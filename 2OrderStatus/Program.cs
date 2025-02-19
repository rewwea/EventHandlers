using System;

namespace OrderStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            var notifier = new OrderStatusNotifier();

            order.StatusChanged += notifier.OnStatusChanged;

            order.Status = "Processing";
            order.Status = "Shipped";
        }
    }
}