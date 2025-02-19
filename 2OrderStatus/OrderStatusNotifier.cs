namespace OrderStatus
{
    public class OrderStatusNotifier
    {
        public void OnStatusChanged(string newStatus)
        {
            Console.WriteLine($"Order status changed to: {newStatus}");
        }
    }
}