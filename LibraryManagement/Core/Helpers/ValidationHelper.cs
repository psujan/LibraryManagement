using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Model;

namespace LibraryManagement.Core.Helpers
{
    public class ValidationHelper
    {
        public static readonly int MAX_BORROW_LIMIT = 3;
        public static bool ValidateUserId(int id)
        {
            var item = new UserController().GetById(id);
            return item == null ?  false : true;
        }

        public static bool ValidateBookId(int id)
        {
            var item = new BookController().GetBookById(id);
            return item == null ? false : true;
        }

        public static bool CheckBookLimit(int id)
        {
            var items = new LibraryControlller().ListIssuedBooks();
            var borrowedBooks = items.FindAll((x)=>x.UserId == id);
            return borrowedBooks.Count >= MAX_BORROW_LIMIT;
        }
    }
}
