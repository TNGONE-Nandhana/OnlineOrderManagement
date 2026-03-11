using System.Globalization;
namespace Create
{
    public class DispOrdWithDateRange
    {
        public void DisplaywithDateRange()
        {
            DateTime fromDate = DateTime.MinValue;
            DateTime toDate = DateTime.MinValue;

            Console.WriteLine("Display Orders Within Date Range");
            
                while (true)
            {
                try
                {
                    Console.WriteLine("Enter FROM date (dd-MM-yyyy):");
                    //fromDate = Convert.ToDateTime(Console.ReadLine());
                    if (DateTime.TryParseExact(
                            Console.ReadLine(),
                            "dd-MM-yyyy",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out fromDate))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid date format. Please enter in dd-MM-yyyy format.");
                }

                catch (FormatException)
                {
                    Console.WriteLine(" Invalid date format. Please enter in dd-MM-yyyy format.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error message: " + ex.Message);
                }
            }
            while (true)
            {

                try
                {
                    Console.WriteLine("Enter TO date (dd-MM-yyyy):");
                    //toDate = Convert.ToDateTime(Console.ReadLine());
                    if (DateTime.TryParseExact(
                            Console.ReadLine(),
                            "dd-MM-yyyy",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out toDate))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid date format. Please enter in dd-MM-yyyy format.");
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Invalid date format. Please enter in dd-MM-yyyy format.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error message: " + ex.Message);
                }
            }
                if (fromDate > toDate)
                {
                    Console.WriteLine("From Date cannot be later than To Date.");
                    return;
                }
            // Ensure end date includes full day
            toDate = toDate.Date.AddDays(1).AddTicks(-1);

            var ordersInRange = CreateOrd.cart
                .Where(c => c.OrderDate >= fromDate && c.OrderDate <= toDate)
                .ToList();

            if (ordersInRange.Count == 0)
            {
                Console.WriteLine("No orders found in this date range.");
                return;
            }



            foreach (var item in ordersInRange)
            {
                Console.WriteLine(
                    $"OrderId:{item.OrderId},  CustomerName:{item.CustName}, Product:{item.Products.Name},  Quantity:{item.Quantity},  Total:{item.total:C}, Date: {item.OrderDate:dd-MM-yyyy}");
            }

        }
    }
}



