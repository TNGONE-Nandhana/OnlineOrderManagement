using Create;

public class TopFive
{
    public void Top()
    {
        var recent =CreateOrd.cart.OrderByDescending(o=>o.OrderDate).Take(5).ToList();
        if (recent.Count == 0)
        {
            Console.WriteLine("No Recent Orders");
            return;
        }
        Console.WriteLine("Top five recent Orders Are:");
        foreach(var five in recent)
        {
            Console.WriteLine($"OrderId:{five.OrderId},CustomerName:{five.CustName},Item :{five.Products.Name},Date:{five.OrderDate}");
        }
        
    }
}