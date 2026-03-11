using Create;

public class HighestPurchaseAmt
{
    public void HighestPurchase()
    {
        Console.WriteLine("View The Highest Purchase amount");
        var h =CreateOrd.cart.OrderByDescending(x=>x.total).FirstOrDefault();
        Console.WriteLine($"CustomerName:{h.CustName},HighestOrder:{h.total}");
    
    }
}