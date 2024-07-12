using LibraryManagement.Core.Helpers;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Core
{
    public class LibraryControlller
    {
        public static readonly int PER_BOOK_FINE = 10;
        
        private List<UsersBook> UserBooks = new List<UsersBook>();
        
        public LibraryControlller()
        {
             this.Load();
        }

        private void Load()
        {
            var userBooks = FileHelper.GetIssuedBookList();
            if (userBooks != null)
            {
                this.UserBooks = userBooks;
            }
        }

        private bool Save() 
        {
            return FileHelper.SaveIssuedBookList(this.UserBooks);
        }


        public bool IssueBook(int userId, int bookId)
        {
            UserBooks.Add(new UsersBook(userId, bookId));
            return this.Save();
        }

        public double CalculateFineAmount(int userId)
        {
            var report = this.GetUserReport(userId);
            double sum =  report.Sum((r) => (int)r["Fine Amount"]);
            return sum;
        }

        public List<UsersBook> ListIssuedBooks()
        {
            return this.UserBooks;
        }

        public List<Dictionary<string, object>> GetUserReport(int id) 
        {
            var items = UserBooks.FindAll((u)=>u.UserId == id);
            var report = new List<Dictionary<string, object>>();
            foreach (var item in items)
            {
                report.Add(new Dictionary<string, object>()
                {
                    {"Book Id" , item.BookId },
                    {"Return Date" , item.ReturnDate },
                    {"Fine Amount" , (DateTime.Today - DateTime.Parse(item.ReturnDate)).Days * PER_BOOK_FINE} 
                });
            }
            return report;
        }
    }
}
