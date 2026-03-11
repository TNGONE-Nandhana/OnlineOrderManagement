using Create;
namespace Create
{
    

public class GetHighest
{
    public void GetHighestValueOrder()
    {
        Console.WriteLine("View The Highest Value Order");
        var h =CreateOrd.cart.OrderByDescending(x=>x.total).FirstOrDefault();
        Console.WriteLine($"OrderId:{ h.OrderId}, Item:{ h.Products.Name}, Quantity:{ h.Quantity}, HighestOrder:{ h.total:C}");
    
    }
}
}