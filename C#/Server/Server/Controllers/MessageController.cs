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
    public class MessageController : ApiController
    {
        [HttpGet]
        public Message[] GetMessageBox(int idUser)
        {
            return MessageManager.GetMessageBox(idUser);
        }

        [HttpPost]
        public bool CreateMessage(string text, int idTo, int idFrom)
        {
            MessageManager.CreateMessage(text, idTo, idFrom);
            return true;
        }
    }
}