using GameStore.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class GamesController : Controller
    {
        private StoreGameContext db = new StoreGameContext();

        // GET: Games
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista( string gameNameType )
        {
            return View();
        }

        public ActionResult Details( string id )
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult GameTypeMenu()
        {
            var gameType = db.GamesTypes.ToList();
            return PartialView("_GameTypeMenu", gameType);
        }
    }
}