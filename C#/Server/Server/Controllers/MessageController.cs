using DataBase;
using DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Web;
using System.Web.Mvc;

namespace Server.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        [ActionName("GetMessageBox")]
        public string GetMessageBox(int idUser)
        {
            return JsonConvert.SerializeObject(MessageManager.GetMessageBox(idUser));
        }

        [HttpPost]
        [ActionName("CreateMessage")]
        public string CreateMessage(string text, int idTo, int idFrom)
        {
            MessageManager.CreateMessage(text, idTo, idFrom);
            return JsonConvert.SerializeObject(true);
        }
    }
}