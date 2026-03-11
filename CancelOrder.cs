namespace Create
{
    public class Cancel
{
    public void CancelOrder()
    {
        int CheckOrdId;
        Console.WriteLine("CANCEL  ORDER");
        Console.WriteLine("Enter ORDERID:");
        string  p= Console.ReadLine();
        if (int.TryParse(p, out CheckOrdId ))
        {
            if (CheckOrdId > 0)
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
        var cancl = CreateOrd.cart.FirstOrDefault(u =>
                u.OrderId.Equals(CheckOrdId));
        if (cancl  == null)
            {
                Console.WriteLine("OrderId  not found");
                return;
            }
        CreateOrd.cart.Remove(cancl);
        Console.WriteLine("Order Cancelled");
        // foreach(var item in CreateOrd.cart)
        //         {
        //             Console.WriteLine($"{item.CustomerName}");
        //         }
    }
}
}