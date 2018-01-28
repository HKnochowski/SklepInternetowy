using GameStore.Data_Access_Layer;
using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class HomeController : Controller
    {
        private StoreGameContext db = new StoreGameContext();

        // GET: Home
        public ActionResult Index()
        {
            GameType GameType = new GameType { NameGameType = "RPG", FileGameType = "RPG.png", DescriptionGameType = "Lorem ipsum set dolor et amen" };
            db.GamesTypes.Add(GameType);
            db.SaveChanges();

            return View();
        }

        public ActionResult StaticSite (string nazwa)
        {
            return View(nazwa);
        }
    }
}