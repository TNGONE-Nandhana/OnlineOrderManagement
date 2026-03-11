
namespace Create
{
    public class TotalOrdValue
    {
        public void TotalOrd()
        {
            Console.WriteLine("Total Order Value ");
            Console.WriteLine("Enter OrderId:");
            int totalid = Convert.ToInt32(Console.ReadLine());


            var orderItems = CreateOrd.cart
                .Where(u => u.OrderId == totalid)
                .ToList();

            if (orderItems.Count == 0)
            {
                Console.WriteLine("Order not found");
                return;
            }
            double totalOrderValue = orderItems.Sum(x => x.total);
            Console.WriteLine($"Total Order Value: {totalOrderValue:C}");


        }
    }
}