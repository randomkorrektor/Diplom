using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class User
    {
        public ObjectId ID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string nickname { get; set; }
        public long date { get; set; }

        public User()
        {
            email = "";
            password = "";
            nickname = "";
            date = 0;
        }
    }
}
