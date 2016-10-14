using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using DataBase;
using DataTypes;

namespace Server.Controllers
{
    public class PostController : ApiController
    {
        [HttpGet]
        public Post[] GetAllPosts()
        {
            return PostManager.GetAllPosts();
        }

        [HttpPost]
        public bool CreatePost(string url, double geoposition, double azimut, int idCreator)
        {
            PostManager.CreatePost(url, geoposition, azimut, idCreator);
            return true;
        }

        [HttpDelete]
        public bool DeletePost(int id)
        {
            PostManager.DeletePost(id);
            return true;
        }

    }
}