namespace Create
{
    public class ViewAllOrd
    {
        public void ViewAllOrders()
        {

            Console.WriteLine("View All Orders Here");
            try
            {


                foreach (var item in CreateOrd.cart)
                {
                    if (item == null)
                    {
                        Console.WriteLine(" Skipping null order entry.");
                        continue;
                    }

                    if (item.Products == null)
                    {
                        Console.WriteLine($" Order {item.OrderId} has no product assigned.");
                        continue;
                    }
                    Console.WriteLine($"{item.OrderId}\t{item.CustName}\t\t{item.Products.Name}\t\t{item.Quantity}");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null Refernce Exception");
            }
        }
    }
}
//Quantity:{item.Quantity}, Price: {item.total:C}
