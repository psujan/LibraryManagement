using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    internal class UserList
    {
        public static Dictionary<string, object>[] userList = new Dictionary<string, object>[]
         {
             new Dictionary<string, object>
             {
                { "Id", 1 },
                { "Name", "John Doe" },
                { "Email", "johndoe@user.com" },
             },
             new Dictionary<string, object>
             {
                { "Id", 2 },
                { "Name", "Eve Cena" },
                { "Email", "evecena@user.com" },
             },
             new Dictionary<string, object>
             {
                { "Id", 3 },
                { "Name", "Alice Smith" },
                { "Email", "alice@user.com" },
             },
             new Dictionary<string, object>
             {
                { "Id", 4 },
                { "Name", "David Peterson" },
                { "Email", "davidp@user.com" },
             },
         };
     }
}
