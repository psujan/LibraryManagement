using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LibraryManagement.Core.Helpers
{
    public class FileHelper
    {
        private static readonly string UserBookFile = "C:\\Users\\User\\source\\repos\\LibraryManagement\\LibraryManagement\\userbook.json";

        public static bool SaveIssuedBookList(List<UsersBook> issuedBooks)
        {
            bool res = false;
            try
            {
                string json = JsonSerializer.Serialize(issuedBooks);
                File.WriteAllText(UserBookFile, json);
                res = true;
                return res;
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error: " + ex.Message);
                return res;
            }
        }

        public static void GetIssuedBookList()
        {

        }
    }
}
