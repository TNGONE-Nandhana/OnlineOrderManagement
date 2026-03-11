namespace Create 
{
    public class SearchOrdByCustomer
{
    public void SearchOrdByCust()
    {   int searchordId;
        Console.WriteLine("Enter OrderId");
        string p = Console.ReadLine();
        if (int.TryParse(p, out searchordId ))
        {
            if (searchordId > 0)
            {
                //Console.WriteLine($" Valid positive integer entered: {m}");
                // You can now use 'number' in your program
            }
            else
            {
                Console.WriteLine(" The number must be positive.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        var ser=CreateOrd.cart.Where(c=>c.OrderId==searchordId).ToList();
        if (ser.Count == 0)
            {
                Console.WriteLine("Order not found");
                return;
            }
        foreach (var item in ser)
            { 
                Console.WriteLine($"{item.Products.Name}\t\t{item.Quantity}\t\t{item.total:C}");
            }
    }
}
} 