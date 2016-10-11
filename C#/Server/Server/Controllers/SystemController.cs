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
    public class SystemController : ApiController
    {
        [HttpGet]
        public bool IsALife()
        {
            return SystemManager.IsALife();
        }
    }
}