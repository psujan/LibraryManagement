using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Views
{
    public class MainMenu
    {
        public static void initMenu()
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
                        InitUserMenu();
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

        public static void InitUserMenu()
        {
            Console.Clear();
        }

    }
}
