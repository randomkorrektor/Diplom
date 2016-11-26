using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Web;
using System.Web.Mvc;
using DataTypes;
using DataBase;

namespace Server.Controllers
{
    public class PostController : Controller
    {

        [HttpGet]
        [ActionName("GetAllPosts")]
        public string GetAllPosts()
        {
            return JsonConvert.SerializeObject(PostManager.GetAllPosts());
        }

        [HttpPost]
        [ActionName("CreatePost")]
        public string CreatePost(string url, double geoposition, double azimut, int idCreator)
        {
            PostManager.CreatePost(url, geoposition, azimut, idCreator);
            return JsonConvert.SerializeObject(true);
        }

        [HttpDelete]
        [ActionName("DeletePost")]
        public string DeletePost(int id)
        {
            PostManager.DeletePost(id);
            return JsonConvert.SerializeObject(true);
        }
    }
}