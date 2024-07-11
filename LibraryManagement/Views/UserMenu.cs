using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Core;
using LibraryManagement.Core.Helpers;
using LibraryManagement.Model;

namespace LibraryManagement.Views
{
    public class UserMenu
    {
        private static readonly int userId = MainMenu.AUTH_USER_ID;
        private BookController BookController;
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

        public UserMenu()
        {
            this.BookController = new BookController();

        }
        public void HandleChoice(string ch)
        {
            switch (ch)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    this.ShowBooks();
                    break;
                case "2":
                    Console.WriteLine("hello Nepali");
                    this.FilterBooks();
                    break;

            }
        }

        public void ShowBooks()
        {
            var items = BookController.Index();
            if (items.Count == 0)
            {
                Console.WriteLine("No Books found");
                return;
            }
            this.DisplayBooks(items);
            this.WishToContinue();

        }
        public void DisplayBooks(List<Book> items)
        {
            if (items == null || items.Count == 0)
            {
                Console.WriteLine("No Record Found");
                this.WishToContinue();
                return;
            }

            Console.WriteLine($"{"Id",-10}{"Name",-40}{"Author",-25}{"Category",-15}{"Pub Year",-10}{"Pages"}");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id,-10}{Helper.TruncateWithEllispsis(item.Name),-40}{Helper.TruncateWithEllispsis(item.Author, 20),-25}{item.Category,-15}{item.PublishedYear,-10}{item.Pages}");
            }
            this.WishToContinue();
        }
        public void FilterBooks()
        {
            var categories = BookController.GetCategories();
            if (categories.Count == 0)
            {
                Console.WriteLine("Category Not found");
                this.WishToContinue();
                return;
            }
            Console.WriteLine("\n Enter the category from the following list:");
            int i = 0;
            foreach (var category in categories)
            {
                Console.WriteLine($"{++i,-10}{category}");
            }
            try
            {
                string cat = Console.ReadLine();
                if (categories.Any(c => c.ToLower() == cat.ToLower()))
                {
                    this.DisplayBooks(BookController.FindBookByCategory(cat));
                }
                else
                {
                    Console.WriteLine("No books found on this category.");
                    this.WishToContinue();
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
        }

        public void WishToContinue()
        {
            Console.WriteLine("\nDo you want to continue ? (y/ n): ");
            char ch = Char.Parse(Console.ReadLine());


            if (ch == 'y' || ch == 'Y')
            {
                Console.Clear();
                this.InitUserMenu();
            }
            else
            {
                Environment.Exit(0);
            }
            return;
        }
    }
}
