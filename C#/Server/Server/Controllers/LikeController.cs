using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Server.Controllers
{
    public class LikeController : Controller
    {
        [HttpPost]
        public void LikeDislike(int idCreator, int idPost)
        {
            LikeManager.LikeDislike(idCreator, idPost);
        }
    }
}