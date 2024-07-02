using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    public class UsersBook
    {
        public int UserId { get; set; }

        public int BookId { get; set; }

        public string ReturnDate {  get; set; }

        public double FineAmount { get; set; }
    }
}
