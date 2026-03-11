using Create;
namespace Create
{
    

public  class CalculateTotalSale
{
    public void CalculateTotalsales()
{
    double totalvalue =CreateOrd.cart.Sum(o=>o.total);
    Console.WriteLine($"Total Sales:{totalvalue:C}");
}
}
}