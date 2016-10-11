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
    public class LikeController : ApiController
    {
        [HttpPost]
        public void LikeDislike(int idCreator, int idPost)
        {
            LikeManager.LikeDislike(idCreator, idPost);
        }
    }
}