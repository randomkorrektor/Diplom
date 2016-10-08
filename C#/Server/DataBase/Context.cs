using DataTypes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Context : DbContext
    {
        public static Context Instance = new Context();
        public DbSet<Comment> comments { get; set; }
        public DbSet<Like> likes { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<User> users { get; set; }

        private Context() { }
    }
}

/*public class SchoolContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<Course> Courses { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
*/