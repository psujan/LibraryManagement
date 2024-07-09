using LibraryManagement.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Views
{
    public class MainMenu
    {
        public static int AUTH_USER_ID;
        public  void InitMenu()
        {
            bool show = true;
            while (show)
            {
                Console.WriteLine("Please Choose Any One");
                Console.WriteLine("(1)    Admin Console");
                Console.WriteLine("(2)    User Console");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        InitAdminMenu();
                        show = false;
                        break;
                    case "2":
                        AuthUser();
                        show = false;
                        break;
                    default:
                        show = true;
                        Console.WriteLine("Your choice doesn't match any options. Reinititalizing after 2 secs");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            }    
            

        }

        public static void InitAdminMenu()
        {
            Console.Clear();
            AdminMenu am = new AdminMenu();
            am.InitAdminMenu();
        }

        public  void AuthUser()
        {
            Console.Clear();
            Console.WriteLine("Enter User Id: ");
            int id = Int32.Parse(Console.ReadLine());

            //validate user id
            if (!ValidationHelper.ValidateUserId(id)) {
                Console.WriteLine($"User with id {id} doesn;t exist");
                this.WishToContinue();
                return;
            }

            // TODO
            //validate user email
            // if valid email then prompt to user menu
            AUTH_USER_ID = id;
            Console.Clear() ;
            UserMenu userMenu = new UserMenu();
            userMenu.InitUserMenu();

        }

        public void WishToContinue()
        {
            Console.WriteLine("\nDo you want to continue ? (y/ n): ");
            char ch = Char.Parse(Console.ReadLine());


            if (ch == 'y' || ch == 'Y')
            {
                Console.Clear();
                InitMenu();
            }
            else
            {
                Environment.Exit(0);
            }
            return;
        }

    }
}
