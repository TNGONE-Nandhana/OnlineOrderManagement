namespace Create
{
    public class CartItem
{
    public   Products  Products {get;set;}
    public int Quantity{get;set;}
    public int OrderId {get;set;}
    public double total =>Products.Price*Quantity;
    public string CustName{get;set;}
    public DateTime OrderDate{get;set;}
}
}