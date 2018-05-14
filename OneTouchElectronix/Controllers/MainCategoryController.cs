using OneTouchElectronix.Interfaces;
using OneTouchElectronix.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OneTouchElectronix.Controllers
{
    public class MainCategoryController : Controller, IController
    {


        ApplicationDbContext db = new ApplicationDbContext();

        //POST : MAinCategory/Delete/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MainCategory mainCategory = db.MainCategories.Find(id);
            db.MainCategories.Remove(mainCategory);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        //GET : MainCategory/Delete /1
        public ActionResult Delete(int ? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainCategory mainCategory = db.MainCategories.Find(id);
            if(mainCategory == null)
            {
                return HttpNotFound();
            }
            return View(mainCategory);
        }


        //POST : MainCategory/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit([Bind(Include ="MainCategoryId, MainCategoryName")] MainCategory mainCategoryEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mainCategoryEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mainCategoryEntity);
        }

        //GET : MainCategory/ Edit/
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainCategory main = db.MainCategories.Find(id);
            if (main == null)
            {
                return HttpNotFound();
            }
            return View(main);
        }

        //GET : Students/Details/5
        public ActionResult Details(int? id)
        {
            
                       
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainCategory mainCategory = db.MainCategories.Find(id);

            if (mainCategory == null)
            {
                return HttpNotFound();
            }
            return View(mainCategory);
        }

        


        // GET: MainCategory
        public ActionResult Index()
        {
            
            return View(db.MainCategories.ToList());
        }

        //GET : MainCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST : MainCategory/Create
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create([Bind(Include = "MainCategoryName, MainCategoryId, MainCategoryDescription")] MainCategory mainCategoryentity)
        {
            if (ModelState.IsValid)
            {
                db.MainCategories.Add(mainCategoryentity);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(mainCategoryentity);
        }

       
        
       

        public ActionResult DeleteConfirmed()
        {
            throw new NotImplementedException();
        }
    }
}