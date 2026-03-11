using System.Linq.Expressions;
namespace Create
{
    public class AdminCreateMenu
    {
        public void AdminMenu()
        {
            Console.WriteLine("Add to Menu");
            string item;
            while (true)
            {
                Console.WriteLine("Enter name of item ");
                item = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(item))
                {
                    Console.WriteLine("Input cannot be empty.");
                    return;
                }
                if (CreateOrd.products.Any(p => p.Name.Equals(item, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Item '{item}' already exists. Enter a different name.");
                    continue;
                }

                break;
            }
            int id;
            while (true)
            {
                Console.WriteLine("Enter ID of item ");
                //int id =Convert.ToInt32(Console.ReadLine());

                string input = Console.ReadLine();
                if (!int.TryParse(input, out id))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }

                bool exists = CreateOrd.products.Any(p => p.Id == id);
                if (exists)
                {
                    Console.WriteLine($"Product with ID {id} exists in the list.");
                    return;
                }
                break;
            }
            // else
            //     Console.WriteLine($"Product with ID {s} does not exist in the list.");
            int price;
            while (true)
            {
                Console.WriteLine("Enter price  of item ");
                string priceInput = Console.ReadLine();
                if (!int.TryParse(priceInput, out price) || price <= 0)
                {
                    Console.WriteLine("Enter a valid price greater than 0.");
                    continue;
                }
                break;
            }

            Products newprod = new Products
            {
                Id = id,
                Name = item,
                Price = price
            };
            CreateOrd.products.Add(newprod);
            Console.WriteLine("New Product Added");


        }
    }
}