using LibraryManagement.Core;
using LibraryManagement.Core.Helpers;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Views
{
    public class AdminMenu
    {
        
        private BookController BookController;

        private UserController UserController;

        private LibraryControlller LibraryControlller;

        public AdminMenu() { 
            this.BookController = new BookController();
            this.UserController = new UserController();
            this.LibraryControlller = new LibraryControlller();
        }

        public void InitAdminMenu()
        {
            try
            {
                Console.WriteLine("Welcome To Admin Console");
                Console.WriteLine("(1)  Issue Book To User");
                Console.WriteLine("(2)  View All Books");
                Console.WriteLine("(3)  Search Book By Id ");
                Console.WriteLine("(4)  Filter Book By Category");
                Console.WriteLine("(5)  Sort Book By Name(ASC)");
                Console.WriteLine("(6)  Sort Book By Publication Date(ASC)");
                Console.WriteLine("(7)  View All Users");
                Console.WriteLine("(8)  View Issued Book List");
                Console.WriteLine("(0)  Exit Admin Console (0 Or Any Other Key)");
                string ch = Console.ReadLine();
                this.HandleChoice(ch);
            }catch(Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }

        }

        private  void HandleChoice(string ch)
        {
           
            switch(ch)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    this.IssueBook();
                    break;
                case "2":
                    this.ListBooks();
                    break;
                case "3":
                    this.GetBookId();
                    break;
                case "4":
                    this.FilterBooks();
                    break;
                case "5":
                    this.SortBooksByName();
                    break;
                case "6":
                    this.SortBooksByPublicationYear();
                    break;
                case "7":
                    this.ListUsers();
                    break;
                case "8":
                    this.ListIssuedBooks();
                    break;
                default:
                    Console.WriteLine("No Matching Case");
                    this.WishToContinue();
                    break;
            }
        }

        public  void ListBooks()
        {
            
            var items = BookController.Index();
            if(items.Count ==  0)
            {
                Console.WriteLine("No records found");
                return;
            }
            this.DisplayBooks(items);
            this.WishToContinue();
        }

        public void GetBookId()
        {
            Console.Clear();
            Console.WriteLine("Please Enter Book Id: ");
            string id = Console.ReadLine();
            try
            {
                int bId = Int32.Parse(id);
                this.FindBookById(bId);
                
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{id}'");
            }


        }

        public  void FindBookById(int id)
        {
            Book? bk = BookController.GetBookById(id);
            if(bk == null)
            {
                Console.WriteLine("No Record Found");
                this.WishToContinue();
                return;
            }
            Console.WriteLine(bk);
            this.WishToContinue();

        }

        public void SortBooksByPublicationYear()
        {
            this.DisplayBooks(BookController.SortBookByPublicationDate());
        }

        public void SortBooksByName()
        {
            this.DisplayBooks(BookController.SortBookByName());
        }


        public void WishToContinue()
        {
            Console.WriteLine("\nDo you want to continue ? (y/ n): ");
            char ch = Char.Parse(Console.ReadLine());
            

            if(ch == 'y' || ch == 'Y')
            {
                Console.Clear();
                this.InitAdminMenu();
            }
            else
            {
                Environment.Exit(0);
            }
            return;
        }

        public void DisplayBooks(List<Book> items)
        {
            if(items == null || items.Count == 0)
            {
                Console.WriteLine("No Record Found");
                this.WishToContinue();
                return;
            }

            Console.WriteLine($"{"Id",-10}{"Name",-40}{"Author",-25}{"Category" , -15}{"Pub Year",-10}{"Pages"}");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id,-10}{Helper.TruncateWithEllispsis(item.Name),-40}{Helper.TruncateWithEllispsis(item.Author, 20),-25}{item.Category , -15}{item.PublishedYear,-10}{item.Pages}");
            }
            this.WishToContinue();
        }

        public void FilterBooks()
        {
            var categories = BookController.GetCategories();

            if(categories.Count == 0)
            {
                Console.WriteLine("No Categories Found");
                this.WishToContinue();
                return;
            }
            Console.WriteLine("\n Please Provide Category From Following List :");
            int i = 0;
            foreach (var category in categories)
            {
                Console.WriteLine($"{++i , -10}{category}");
            }
            try
            {
                string ch = Console.ReadLine();
                if(categories.Any(c => c.ToLower() == ch.ToLower()))
                {
                    this.DisplayBooks(BookController.FindBookByCategory(ch));
                }
                else
                {
                    Console.WriteLine($"Category {ch} doesn't match with any item in the list");
                    this.WishToContinue();
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void ListUsers()
        {
            this.DisplayUsers(UserController.Index());
        }

        public void DisplayUsers(List<User> users)
        {
            if(users.Count == 0)
            {
                Console.WriteLine("No Record Found");
                this.WishToContinue();
                return;
            }

            Console.WriteLine($"{"Id",-7}{"Name",-30}{"Email"}");
            Console.WriteLine("---------------------------------------------------------------");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id,-7}{Helper.TruncateWithEllispsis(user.Name, 25),-30}{user.Email}");
            }

            this.WishToContinue();

        }

        public void IssueBook()
        {
            Console.Clear();
            Console.WriteLine("Enter Book Id: ");
            int bId = Int32.Parse(Console.ReadLine());
            if (!ValidationHelper.ValidateBookId(bId))
            {
                Console.WriteLine($"Book with id {bId} does not exist");
                this.WishToContinue();
                return;
            }
            Console.WriteLine("Enter User Id: ");
            
            int uId = Int32.Parse(Console.ReadLine());
            if (!ValidationHelper.ValidateUserId(uId))
            {
                Console.WriteLine($"User with id {uId} does not exist");
                this.WishToContinue();
                return;
            }
            bool succ = LibraryControlller.IssueBook(uId, bId);
            if (succ)
            {
                Console.WriteLine("Book Issued Successfully");
            }
            else
            {
                Console.WriteLine("Failed To Issue Book");
            }
            this.WishToContinue();
        }

        public void ListIssuedBooks()
        {
            List<UsersBook> items = LibraryControlller.ListIssuedBooks();
            foreach (UsersBook item in items)
            {
                Console.WriteLine(item);
            }
            this.WishToContinue() ;
        }
    }
}
