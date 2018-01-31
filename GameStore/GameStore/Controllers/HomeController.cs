using GameStore.Data_Access_Layer;
using GameStore.Models;
using GameStore.ViewModels;
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
            //TEST var Test = db.Games.ToList();
            var newsActive = db.Games.Where(a => a.OrToBuy).OrderByDescending(a => a.GamePremiere).Take(1).ToList();
            var news = db.Games.Where(a => a.OrToBuy).OrderByDescending(a => a.GamePremiere).Take(2).ToList();
            var bestsellery = db.Games.Where(a => a.OrToBuy && a.GameRating <= 9).OrderBy(a => Guid.NewGuid()).Take(3).ToList();
            var recommended = db.Games.Where(a => a.OrToBuy && a.OrRecommended).OrderBy(a => Guid.NewGuid()).Take(3).ToList();
            var gameType = db.GamesTypes.OrderByDescending(a => a.NameGameType).ToList();

            var vm = new HomeViewModel()
            {
                NewsActive = newsActive,
                News = news,
                Bestsellery = bestsellery,
                Recommended = recommended,
                gameType = gameType
            };

            return View(vm);
        }

        public ActionResult StaticSite (string nazwa)
        {
            return View(nazwa);
        }

        public ActionResult ViewLoginWindow (string nazwa)
        {
            return View(nazwa);
        }
    }
}