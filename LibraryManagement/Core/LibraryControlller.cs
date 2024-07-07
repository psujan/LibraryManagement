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
        private List<UsersBook> UserBooks = new List<UsersBook>();
        
        public LibraryControlller()
        {
            this.Load();
        }

        private void Load()
        {

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

        public void CalculateFineAmount(int userId)
        {

        }


    }
}
