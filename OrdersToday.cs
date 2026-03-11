using Create;
namespace Create
{
public class OrdersToday
{
    public void OrderToday()
    {
       var today =CreateOrd.cart.Where(t=>t.OrderDate.Date==DateTime.Today);
       foreach(var t in today)
        {
            Console.WriteLine($"OrderId:{t.OrderId} , Name:{t.CustName},Item :{t.Products.Name}");
        } 
    }
}
}