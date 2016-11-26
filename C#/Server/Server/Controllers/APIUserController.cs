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
   public class APIUserController : ApiController
    {
        [HttpPost]
        public string Registration([FromUri]string email, [FromUri]string password, [FromUri]string nickname)
        {
            bool regQuestion = UserManager.Registration(email, password, nickname);
            if (regQuestion)
                return UserManager.logIn(email, password);
            else
                return "Error";
            
        }

        [HttpGet]
        public string LogIn([FromUri]string email,[FromUri]string password)
        {
            string userNick = "";
            userNick= UserManager.logIn(email, password);
            if (userNick!="Error")
                return userNick;
            else
                return "Error";
        }
    }
}
