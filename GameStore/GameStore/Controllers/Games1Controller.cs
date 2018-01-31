using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameStore.Data_Access_Layer;
using GameStore.Models;

namespace GameStore.Controllers
{
    public class Games1Controller : Controller
    {
        private StoreGameContext db = new StoreGameContext();

        // GET: Games1
        public ActionResult Index()
        {
            var games = db.Games.Include(g => g.GameType);
            return View(games.ToList());
        }

        // GET: Games1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // GET: Games1/Create
        public ActionResult Create()
        {
            ViewBag.GameTypeId = new SelectList(db.GamesTypes, "GameTypeId", "NameGameType");
            return View();
        }

        // POST: Games1/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameId,GameTypeId,GameName,GameDescription,GamePremiere,GameRating,OrToBuy,OrRecommended,NameFileNews,NameFileBestseller,NameFileRecomended")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GameTypeId = new SelectList(db.GamesTypes, "GameTypeId", "NameGameType", game.GameTypeId);
            return View(game);
        }

        // GET: Games1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            ViewBag.GameTypeId = new SelectList(db.GamesTypes, "GameTypeId", "NameGameType", game.GameTypeId);
            return View(game);
        }

        // POST: Games1/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameId,GameTypeId,GameName,GameDescription,GamePremiere,GameRating,OrToBuy,OrRecommended,NameFileNews,NameFileBestseller,NameFileRecomended")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GameTypeId = new SelectList(db.GamesTypes, "GameTypeId", "NameGameType", game.GameTypeId);
            return View(game);
        }

        // GET: Games1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Games1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = db.Games.Find(id);
            db.Games.Remove(game);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
