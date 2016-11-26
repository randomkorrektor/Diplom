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

        public static bool Registration(string email, string password, string nickname)
        {
            var users = Context.Instance.users.Where(u => u.email == email);
            if (users.Count() > 0)
            {
                return false;
            }

            Context.Instance.users.Add(new User()
            {
                email = email,
                password = password,
                nickname = nickname,
                date = DateTime.Now
            });

            Context.Instance.SaveChanges();
            return true;
        }

        public static string logIn(string email, string password)
        {
            try
            {
                var user = Context.Instance.users.First(u => u.email == email && u.password == password);
                return user.nickname;
            }
            catch
            {
                return "Error";
            }

        }
    }
}
