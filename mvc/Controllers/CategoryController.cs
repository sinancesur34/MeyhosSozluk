using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }
            public ActionResult  GetCatgoryList()
            {
                var categoryvalues = cm.GetAllBl();
            return View(categoryvalues);
            }
        }
    }
