using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OneTouchElectronix.Models;

namespace OneTouchElectronix.Controllers
{
    public class TESTsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TESTs
        public ActionResult Index()
        {
            return View(db.TESTs.ToList());
        }

        // GET: TESTs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TEST tEST = db.TESTs.Find(id);
            if (tEST == null)
            {
                return HttpNotFound();
            }
            return View(tEST);
        }

        // GET: TESTs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TESTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,DOB")] TEST tEST)
        {
            if (ModelState.IsValid)
            {
                db.TESTs.Add(tEST);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tEST);
        }

        // GET: TESTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TEST tEST = db.TESTs.Find(id);
            if (tEST == null)
            {
                return HttpNotFound();
            }
            return View(tEST);
        }

        // POST: TESTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,DOB")] TEST tEST)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tEST).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tEST);
        }

        // GET: TESTs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TEST tEST = db.TESTs.Find(id);
            if (tEST == null)
            {
                return HttpNotFound();
            }
            return View(tEST);
        }

        // POST: TESTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TEST tEST = db.TESTs.Find(id);
            db.TESTs.Remove(tEST);
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
