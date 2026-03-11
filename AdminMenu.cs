
namespace Create{
    public class Admin
{
    public void AdminMenu()
    {
        ViewAllOrd view=new ViewAllOrd();
        GetHighest high =new GetHighest();
        CalculateTotalSale sale=new CalculateTotalSale();
        OrdersToday tod =new OrdersToday();
        TopFive top = new TopFive();
        HighestPurchaseAmt hightot=new HighestPurchaseAmt();
        GroupByCust grpbycus=new GroupByCust();
        SortByDate sort =new SortByDate();
        DispOrdWithDateRange dor =new DispOrdWithDateRange();
        AdminCreateMenu men =new AdminCreateMenu();
        ExitAdmin ex =new ExitAdmin();


        Console.WriteLine("ADMIN ");
        Console.WriteLine("1.View all Order");
        Console.WriteLine("2.Get Highest Value Order");
        Console.WriteLine("3.Find Total Sales");
        Console.WriteLine("4.Order Today");
        Console.WriteLine("5.Get top 5 recent orders");
        Console.WriteLine("6.find  highest purchase Amount");
        Console.WriteLine("7.Group order by customer");
        Console.WriteLine("8.Sort By Date");
        Console.WriteLine("9.Display order within Date Range");
        Console.WriteLine("10.Add Menu");
       //  Console.WriteLine("11.Exit Admin");
        Console.WriteLine("Enter option:");
        int option =int.Parse(Console.ReadLine());
         if(option >= 1 && option <= 11)
            {
                Console.WriteLine($"you choose role: {option}");
            }
        else
            {
                Console.WriteLine("Enter a valid number");
                
            }
       
       while(true)
       {
            try{

            switch (option)
        {
            case 1:view.ViewAllOrders();
                   break;
            case 2:high.GetHighestValueOrder();
                   break;
            case 3:sale.CalculateTotalsales();
                   break;
            case 4:tod.OrderToday();
                   break;
            case 5:top.Top();
                   break;
            case 6:hightot.HighestPurchase();
                   break;
            case 7:grpbycus.GroupCust();
                   break;
            case 8:sort.SortDate();
                   break;
            case 9:dor.DisplaywithDateRange();
                   break;
            case 10:men.AdminMenu();
                   break;
            case 11:ex.ExitAd();
                   return;
            default:Console.WriteLine("Enter valid input option ");
                    break;

        }
            }
       catch(FormatException)
        {
            Console.WriteLine("Enter a valid input");
        }

    }
}
}
}