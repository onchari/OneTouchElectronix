﻿using OneTouchElectronix.Interfaces;
using OneTouchElectronix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneTouchElectronix.Controllers
{
    public class MainCategoryController : Controller, IControllers
    {


        ApplicationDbContext db = new ApplicationDbContext();
       

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

        public ActionResult Delete()
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

        public ActionResult DeleteConfirmed()
        {
            throw new NotImplementedException();
        }
    }
}