using DataTypes;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Context : DbContext
    {
        public static Context Instanse = new Context();
        private MongoClient client;
        private IMongoDatabase database;

        private Context()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ServerDB"].ConnectionString;
            client = new MongoClient(connectionString);
            database = client.GetDatabase(ConfigurationManager.AppSettings["DBName"]);
        }

        public void DropDB ()
        {
            database.Client.DropDatabase(ConfigurationManager.AppSettings["DBName"]);
        }







        //public DbSet<Comment> comments { get; set; }
        //public DbSet<Like> likes { get; set; }
        //public DbSet<Message> messages { get; set; }
        //public DbSet<Post> posts { get; set; }
        //public DbSet<User> users { get; set; }
    }
}