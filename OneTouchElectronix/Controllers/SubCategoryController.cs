using OneTouchElectronix.Interfaces;
using OneTouchElectronix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneTouchElectronix.Controllers
{
    public class SubCategoryController : Controller, IControllers
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
       public ActionResult Create([Bind(Include ="SubCategoryId, SubCategoryName, MainCategoryId")] SubCategory subCategoryentity)
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

        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }

        public ActionResult DeleteConfirmed()
        {
            throw new NotImplementedException();
        }

        public ActionResult Details()
        {
            throw new NotImplementedException();
        }

        public ActionResult Edit()
        {
            throw new NotImplementedException();
        }

        public ActionResult Index()
        {
            return View(db.SubCategories.ToList());
            
        }
    }
}