using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista( string GameName )
        {
            return View();
        }

        public ActionResult Details( string id )
        {
            return View();
        }
    }
}