using Create;

public class GroupByCust
{
    public void GroupCust()
    {
        var groupord = CreateOrd.cart.GroupBy(c => c.CustName);
        foreach (var customerGroup in groupord)
        {
            Console.WriteLine($"Customer: {customerGroup.Key}");

            foreach (var item in customerGroup)
            {
                Console.WriteLine(
                    $"  OrderId: {item.OrderId}, Product: {item.Products.Name}, Qty: {item.Quantity}, Total: {item.total:C}");
            }

        }
    }
}