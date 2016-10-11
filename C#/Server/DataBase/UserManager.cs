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
            var users = Context.Instance.users.Where(u => u.email == email);
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
            //try
            //{
                var user = Context.Instance.users.First(u => u.email == email && u.password == password);
                return user.ID;
            //}
            //catch
            //{
            //    return -1;
            //} 
            
        }
    }
}
