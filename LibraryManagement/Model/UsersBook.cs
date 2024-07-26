using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    public class UsersBook
    {
        private static double MAX_DAY = 3;
        public int UserId { get; set; }

        public int BookId { get; set; }

        public string ReturnDate {  get; set; }

        public UsersBook(int userId, int bookId)
        {
            UserId = userId;
            BookId = bookId;
            ReturnDate = DateTime.Now.AddDays(MAX_DAY).ToString();
        }

        public override string ToString()
        {

            return $"User Id : {UserId} \t Book Id: {BookId} \t Return Date: {ReturnDate}";
        }
    }
}
