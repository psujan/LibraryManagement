using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Core.Helpers;
using LibraryManagement.Model;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagement.Core
{
    public class UserController
    {
        private List<User> users = new List<User>();

        private static bool isLoaded = false;
        public UserController() 
        {
            this.Load();
        }

        public List<User> Index()
        {
            return users;
        }

        private void Load()
        {
            if (isLoaded)
            {
                return;
            }

            Dictionary<string, object>[] userList = UserList.userList;

            foreach (var user in userList)
            {
                // the line just below is a bad code call ! It works somehow !!
                User u = Helper.DictToObj<User>(user);
                users.Add(u);
            }
            isLoaded = true;
        }
    }
}
