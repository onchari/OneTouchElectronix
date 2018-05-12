using OneTouchElectronix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneTouchElectronix.Controllers
{
    public class MainCategoryController : Controller
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
    }
}