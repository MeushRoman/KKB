using KKB.BankClient.BLL.User;
using KKB.BankClient.BLL.User.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.BankClient.Web.Model
{
    class ServiceNew
    {

        private static ServiceUser service = null;

        static SeviceNew()
        {
            service = new ServiceUser();
        }

        public static void MainMenu()
        {
            Console.WriteLine("Добро пожаловать в KKB!\n");
            Console.WriteLine("1. Регистрация");
            Console.WriteLine("2. Вход");

            
        }
        public static void AvthorizeMenu(User user)
        {
            Console.Clear();
            Console.WriteLine("Приветствуем Вас, {0} {1}", user.FirstName, user.LastName);

            Console.WriteLine("1. Вывод  баланса на экран");
            Console.WriteLine("2. Пополнение счета");
            Console.WriteLine("3. Снять деньги со счета");
            Console.WriteLine("4. Выход");
        }

        public void RegisterMenu()
        {
            Console.Clear();

            Console.WriteLine("Форма регистрации пользователя\n");

            User user = new User();
        }


        public static void LogOnMenu()
        {
            Console.Clear();

            Console.WriteLine(" ");
            Console.Write("Login");
            string login = Console.ReadLine();
            Console.Write("Password");
            string password = Console.ReadLine();

            string message = "";
            User user = service.LogOn(login, password, out message);

            if (user != null)
            {
                AvthorizeMenu(user);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;

                LogOnMenu();
            }

        }
    }
}
