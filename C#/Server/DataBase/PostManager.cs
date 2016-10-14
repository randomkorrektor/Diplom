using DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public static class PostManager
    {
        public static Post[] GetAllPosts()
        {
            return Context.Instance.posts.ToArray();
        }

        public static void CreatePost(string url,double geoposition, double azimut, int idCreator)
        {
            Context.Instance.posts.Add(new Post()
            {
                url = url,
                geoposition = geoposition,
                azimut = azimut,
                idCreator = idCreator,
                date = DateTime.Now.Ticks
            });

            Context.Instance.SaveChanges();
        }

        public static void DeletePost(int id)
        {
            Post post = Context.Instance.posts.First(u => u.ID == id);
            Context.Instance.posts.Remove(post);
            Context.Instance.SaveChanges();
        }

        //public static Post GetPost(int postID)
        //{

        //}

    }
}
