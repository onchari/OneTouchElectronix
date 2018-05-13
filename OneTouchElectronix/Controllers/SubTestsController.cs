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
    public class SubTestsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SubTests
        public ActionResult Index()
        {
            return View(db.SubTests.ToList());
        }

        // GET: SubTests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubTests subTests = db.SubTests.Find(id);
            if (subTests == null)
            {
                return HttpNotFound();
            }
            return View(subTests);
        }

        // GET: SubTests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubTests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SubTestId,SubTestName")] SubTests subTests)
        {
            if (ModelState.IsValid)
            {
                db.SubTests.Add(subTests);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subTests);
        }

        // GET: SubTests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubTests subTests = db.SubTests.Find(id);
            if (subTests == null)
            {
                return HttpNotFound();
            }
            return View(subTests);
        }

        // POST: SubTests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SubTestId,SubTestName")] SubTests subTests)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subTests).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subTests);
        }

        // GET: SubTests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubTests subTests = db.SubTests.Find(id);
            if (subTests == null)
            {
                return HttpNotFound();
            }
            return View(subTests);
        }

        // POST: SubTests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubTests subTests = db.SubTests.Find(id);
            db.SubTests.Remove(subTests);
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
