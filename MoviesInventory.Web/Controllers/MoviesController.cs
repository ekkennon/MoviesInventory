using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MoviesInventory.Web.Models;
using MoviesInventory.Domain;

namespace MoviesInventory.Web.Controllers
{
    public class MoviesController : Controller
    {
        private MovieDbContext db = new MovieDbContext();

        

        // GET: /Movies/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movies = db.Movies.Find(id);
            
            
            if (movies == null)
            {
                return HttpNotFound();
            }
            return View(movies);
        }

        // GET: /Movies/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include="ID,Title,ReleaseDate,Note,RunningTime,Owner,Barcode,Format,Location")] Movie movies)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movies);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movies);
        }

        // GET: /Movies/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movies = db.Movies.Find(id);
            if (movies == null)
            {
                return HttpNotFound();
            }
            return View(movies);
        }

        // POST: /Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include="ID,Title,ReleaseDate,Genre,Price")] Movie movies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movies).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movies);
        }

        // GET: /Movies/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movies = db.Movies.Find(id);
            if (movies == null)
            {
                return HttpNotFound();
            }
            return View(movies);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movies = db.Movies.Find(id);
            db.Movies.Remove(movies);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: /Movies/Index
        [Authorize]
        public ActionResult Index(string letter, string searchString)
        {
            var LttrLst = new List<string>();

            var LttrQry = from d in db.Movies orderby d.Title select d.Title.Substring(0, 1).ToUpper();
            LttrLst.AddRange(LttrQry.Distinct());
            //LttrQry = LttrQry.Distinct();

            ViewBag.Letters = LttrLst;

            var movies = from m in db.Movies select m;
            if (letter != null)
            {
                movies = movies.Where(s => s.Title.StartsWith(letter));
            }
            
            
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }
                return View(movies); 
            //return View(db.Movies.ToList());
            //http://msdn.microsoft.com/en-us/data/jj591621
        }

        // GET: /Movies/QuickAdd
        [Authorize]
        public ActionResult QuickAdd()
        {
            return View();
        }

        // POST: /Movies/QuickAdd
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult QuickAdd([Bind(Include = "ID,Title,ReleaseDate,RunningTime")] Movie movies)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movies);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movies);
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
