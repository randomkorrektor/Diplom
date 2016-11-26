using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class User
    {
        public long ID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string nickname { get; set; }
        public DateTime date { get; set; }

        public User()
        {
            email = "";
            password = "";
            nickname = "";
            date = DateTime.Now;
        }
    }
}
