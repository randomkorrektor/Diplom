using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTypes;

namespace DataBase
{
    public static class UserManager
    {
        public static bool Registration(string email, string password)
        {
            var users = Context.Instance.users.Where(u => u.email == email && u.password == password);
            if (users.Count() > 0)
            {
                return false;
            }

            Context.Instance.users.Add(new User()
            {
                email = email,
                password = password
            });

            Context.Instance.SaveChanges();
            return true;
        }

        public static int logIn(string email, string password)
        {
            var user = Context.Instance.users.First(u => u.email == email && u.password == password);
            if (user==null)
            {
                return -1;
            }
            return user.ID;
        }

    }
}
