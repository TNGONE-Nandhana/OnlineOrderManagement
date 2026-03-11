using Create;
using Microsoft.VisualBasic;
namespace Create
{
     public class UpdateOrd
    {
        //  CreateOrd create = new CreateOrd();

        // // Step 1: Add items to cart
        // create.CreateOrder(); // User selects products

        // private CreateOrd create ;
        // public UpdateOrd(CreateOrd createOrd)
        // {
        //     create=createOrd;
        // }
       //CreateOrd create = new CreateOrd();
        public void UpdateOrder()
        {int CheckOrdId;
            Console.WriteLine("UPDATE ORDER");
            Console.WriteLine("Enter OrderId:");
            string p = Console.ReadLine();
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

            // foreach(var item in CreateOrd.cart)
            //     {
            //         Console.WriteLine($"{item.Products.Name}");
            //     }
            var upd = CreateOrd.cart.FirstOrDefault(u =>
                u.OrderId.Equals(CheckOrdId));

            //var  upd = CreateOrd.cart.FirstOrDefault(u => u.Products.Name.Equals(CheckOrdName, StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine($"{upd.Products.Name}");
            if (upd  == null)
            {
                Console.WriteLine("Item not found");
                return;
            }
            Console.WriteLine("Enter new quantity");
            int qty = Convert.ToInt32(Console.ReadLine());
            upd.Quantity = qty;
            //upd.total = upd.Products.Price * upd.Quantity;
            Console.WriteLine("quantity updated ");

        }
    }
}