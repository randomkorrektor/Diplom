using DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public static class LikeManager
    {
        public static void LikeDislike(int idCreator, int idPost)
        {
            try
            {
                var like = Context.Instance.likes.First(u => u.idCreator == idCreator && u.idPost == idPost);
                Context.Instance.likes.Remove(like);
            }
            catch
            {
                Context.Instance.likes.Add(new Like
                {
                    idCreator=idCreator,
                    idPost=idPost
                });

                //Context.Instance.SaveChanges();
            }
        }
    }
}
