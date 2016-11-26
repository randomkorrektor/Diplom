using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace Server.Controllers
{
    public class UserController : Controller
    {
        [HttpPost]
        [ActionName("SignUp")]
        public string SignUp(string email, string password, string nickname)
        {
            bool regQuestion = UserManager.Registration(email, password, nickname);
            if (regQuestion)
                return JsonConvert.SerializeObject(UserManager.logIn(email, password));
            else
                return JsonConvert.SerializeObject("Error");

        }

        [HttpGet]
        [ActionName("SignIn")]
        public string SignIn(string email, string password)
        {
            string userNick = "";
            userNick = UserManager.logIn(email, password);
            if (userNick != "Error")
                return JsonConvert.SerializeObject("userNick");
            else
                return JsonConvert.SerializeObject("Error");
        }
    }
}