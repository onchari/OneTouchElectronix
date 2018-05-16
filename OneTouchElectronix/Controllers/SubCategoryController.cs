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
    public class SubCategoryController : Controller, IController
    {
        ApplicationDbContext db = new ApplicationDbContext();

        //GET : SubCategory/Create
        public ActionResult Create()
        {
            ViewBag.MainCategoryId = new SelectList(db.MainCategories, "MainCategoryId", "MainCategoryName");
            return View();
        }

       //POST : SubCategory/Create
       [HttpPost]
       [ValidateAntiForgeryToken]
       public ActionResult Create([Bind(Include = "SubCategoryId, SubCategoryName, MainCategoryId, SubCategoryDescription")] SubCategory subCategoryentity)
        {
            if (ModelState.IsValid)
            {
                db.SubCategories.Add(subCategoryentity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MainCategoryId = new SelectList(db.MainCategories, "MainCategoryId", "MainCategoryName", subCategoryentity.MainCategoryId);
            return View(subCategoryentity);
        }

        //GET : SubCategory/Delete/4
        public ActionResult Delete(int? id)
        {
           if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategory subCategory = db.SubCategories.Find(id);
            if (subCategory == null)
            {
                return HttpNotFound();
            }
                return View(subCategory);
            
           
        }


        //POST : SubCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            SubCategory subCategory = db.SubCategories.Find(id);
            db.SubCategories.Remove(subCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        

        //GET : SubCategories /Details/4
        public ActionResult Details(int ? id)
        {
           if(id != null)
            {
                SubCategory subCategory = db.SubCategories.Find(id);
                if(subCategory != null)
                {
                    return View(subCategory);
                }
                return HttpNotFound();
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        //GET : SubCategory?Edit /4
        public ActionResult Edit(int ? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategory subCategory = db.SubCategories.Find(id);
            if (subCategory == null)
            {
                return HttpNotFound();
            }
            ViewBag.MainCategoryId = new SelectList(db.MainCategories, "MainCategoryId", "MainCategoryName", subCategory.SubCategoryId);
            return View(subCategory);
        }

        //POST : Subcategories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit([Bind(Include ="SubCategoryId, SubCategoryName,MainCategoryId")] SubCategory subCategoryEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subCategoryEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subCategoryEntity);
        }

        public ActionResult Index()
        {
            var query = db.SubCategories;
           
                return View(query.ToList());
            
            
            
        }
    }
}