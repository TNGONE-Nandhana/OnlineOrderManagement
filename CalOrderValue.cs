using System.Linq.Expressions;
using Create;

public class CalOrderValue
{
    public void Calculate()
    {
        int m;
        Console.WriteLine("Enter Order ID");
        string  p = Console.ReadLine();
        if (int.TryParse(p, out m ))
        {
            if (m > 0)
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
        
        var upd = CreateOrd.cart.FirstOrDefault(u =>
                 u.OrderId.Equals(m));
        if (upd == null)
        {
            Console.WriteLine("OrderId  not found");
            return;
        }
        
        
         var details = CreateOrd.products.FirstOrDefault(n => n.Id == m);
         Console.WriteLine($"Price :{details.Price}");
        

    }
}