using System.Linq.Expressions;
using System.Net.Mail;
namespace Create{
public class Program
{
  // //updateOrd.UpdateOrder();
      public static int OrderCount = 1;
   
    public static void Main(string[] args)
    {
        // CreateOrd createOrd = new CreateOrd();
        // //createOrd.CreateOrder();

        // UpdateOrd updateOrd = new UpdateOrd();
      
        while (true){
        Console.WriteLine("Online OrderManagement System");
        Console.WriteLine("1.User");
        Console.WriteLine("2.Admin");
        Console.WriteLine("Enter role:");
        
        User users =new User();
        Admin admin=new Admin();
        try{
            int role =Convert.ToInt32(Console.ReadLine());
        
        if(role==1|| role == 2)
            {
                Console.WriteLine($"you choose role:{role}");
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
        
        
        
        switch (role)
        {
            case 1:users.UserMenu();
                   break;
            case 2:admin.AdminMenu();
                   break;
            default:Console.WriteLine("Enter valid input");
                    break;

        }
        }
        catch(FormatException)
        {
            Console.WriteLine("Enter a valid input");
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

    }
    }
}
}

