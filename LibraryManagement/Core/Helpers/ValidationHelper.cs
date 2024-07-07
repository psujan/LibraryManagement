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
    }
}
