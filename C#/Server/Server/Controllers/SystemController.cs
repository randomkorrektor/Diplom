using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace Server.Controllers
{
    public class SystemController : Controller
    {
        [HttpGet]
        [ActionName("IsALife")]
        public string IsALife()
        {
            return JsonConvert.SerializeObject(SystemManager.IsALife());
        }
    }
}