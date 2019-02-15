using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KKB.BankClient.BLL.User;
using KKB.BankClient.BLL.User.Account;



namespace KKB.BankClient.Web
{
    class Program
    {

        static void Main(string[] args)
        {
            ServiceUser service = new ServiceUser();
            User user = new User();
            user.LastName = "asda";
            user.FirstName = "ada";
            user.Login = "admin";
            user.Password = "admin";

            string message = "";

            if (service.RegisterUser(user, out message))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
