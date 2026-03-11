using System.Reflection;

namespace Create;
 public class User{
    
     public  void UserMenu()
    {    bool keeprunning =true;
        while (keeprunning)
        {
            
        
        Console.WriteLine("USER ");
        Console.WriteLine("1.Create Order");
        Console.WriteLine("2.Update Order");
        Console.WriteLine("3.Cancel  Order");
        Console.WriteLine("4.Search Order By Customer ");
         Console.WriteLine("5.Total Order Value ");
         Console.WriteLine("6.Exit User ");

        Console.WriteLine("Enter option:");
        int option =Convert.ToInt32(Console.ReadLine());
        CreateOrd ord =new CreateOrd();
        UpdateOrd upd =new UpdateOrd();
        Cancel cnl =new Cancel();
        SearchOrdByCustomer soc=new SearchOrdByCustomer();
        TotalOrdValue tot=new TotalOrdValue();
        ExitUser ext =new ExitUser();
        
            
           
        if(option >= 1 && option <= 6)
            {
                Console.WriteLine($"you choose option: {option}");
            }
        else
            {
                Console.WriteLine("Enter a valid number");
            }
        
       
        switch (option)
        {
            case 1:ord.CreateOrder();
                   break;
            case 2:upd.UpdateOrder();
                   break;
            case 3:cnl.CancelOrder();
                   break;
            case 4:soc.SearchOrdByCust();
                   break;
            case 5:tot.TotalOrd();
                   break;
            case 6:ext.Exit();
                   return;
            default:Console.WriteLine("Enter valid input option ");
                    break;

        }

    }
    }
}