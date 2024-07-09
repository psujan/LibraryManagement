using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Views
{
    public class UserMenu
    {
        private static readonly int userId = MainMenu.AUTH_USER_ID;

        
        public void InitUserMenu()
        {
            try
            {
                Console.WriteLine("Welcome To User Console");
                Console.WriteLine("(1)  View All Books");
                Console.WriteLine("(2)  Filter Book By Category");
                Console.WriteLine("(3)  Request A Book");
                Console.WriteLine("(4)  Return Borrowed Book");
                Console.WriteLine("(5)  View My Report");
                Console.WriteLine("(0)  Exit  Console (0 Or Any Other Key)");
                string ch = Console.ReadLine();
                this.HandleChoice(ch);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        public void HandleChoice(string ch)
        {
            
        }
    }
}
