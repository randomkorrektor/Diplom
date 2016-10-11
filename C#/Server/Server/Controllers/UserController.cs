using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
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
   public class UserController : ApiController
    {
        [HttpPost]
        public int Registration([FromUri]string email, [FromUri]string password )
        {
            bool regQuestion = UserManager.Registration(email, password);
            if (regQuestion)
                return UserManager.logIn(email, password);
            else
                return -1;
            
        }

        [HttpGet]
        public int LogIn([FromUri]string email,[FromUri]string password)
        {
            int userId = UserManager.logIn(email, password);
            if (userId > 0)
                return userId;
            else
                return -1;
        }
    }
}
