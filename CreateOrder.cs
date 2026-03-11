
using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Create
{
    public class CreateOrd
    {
        public static List<Orders> order = new List<Orders>();
        public static List<CartItem> cart = new List<CartItem> { };
        public static List<Products> products = new List<Products>
        {
            new Products{Id =1,Name =" Icecream" ,Price=20},
            new Products{Id =2,Name =" Burger" ,Price=200},
            new Products{Id =3,Name =" Pizza" ,Price=300},
            new Products{Id =4,Name =" Fried Chicken" ,Price=400},

        };
        // int OrderCount = 1;


        public void CreateOrder()
        {
            Console.WriteLine("CREATE AN ORDER");


            Console.WriteLine("MENU");
            foreach (var item in products)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Price: {item.Price:C}");
            }
            Console.WriteLine("Enter ID you want to order:");
            var orderselected = int.Parse(Console.ReadLine());
            if (orderselected >= 1 && orderselected <= 4)
            {
                Console.WriteLine($"you choose OrderID: {orderselected}");
            }
            else
            {
                Console.WriteLine("Enter a valid id");
                return;
            }
            var details = products.FirstOrDefault(p => p.Id == orderselected);


            //Console.WriteLine($"{details.Name},{details.Price},{details.Id}");

            
            int quantity;
            Console.WriteLine("Enter Quantity  you want to order:");
            string p = Console.ReadLine();
            if (int.TryParse(p, out quantity))
            {
                if (quantity > 0)
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

            Products products1 = new Products();
            // List<CartItem> cart = new List<CartItem>{};
            // {
            //     new CartItem {Products = details, Quantity = quantity}
            // };
            Console.Write("Enter name:");
            string customername = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(customername))
            {
                Console.WriteLine("Input cannot be empty.");
                return;
            }

            cart.Add(new CartItem { Products = details, Quantity = quantity, OrderId = Program.OrderCount, CustName = customername, OrderDate = DateTime.Now });

            // foreach (var item in cart)
            // {
            //     Console.WriteLine($"{item.Products.Name},{item.Quantity},{item.total}");
            // }
            Console.WriteLine($"ORDER ID:{Program.OrderCount}");

            Orders newOrder = new Orders
            {
                OrderId = Program.OrderCount,
                CustomerName = customername,
                OrderDate = DateTime.Now
            };
            order.Add(newOrder);
            //  foreach(var item in order)
            //     {
            //       Console.WriteLine($"{item.CustomerName},{item.OrderId},{item.OrderDate}"); 
            //     }
            //Console.WriteLine($"OrderId={Program.OrderCount}");
            Program.OrderCount++ ;
            //Console.WriteLine(OrderCount);
            Console.WriteLine("Order Created Succesfully");
        }
    }
}
