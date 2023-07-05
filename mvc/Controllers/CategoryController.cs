using BusinessLayer.Concrete;
using EntityLayer.concrete;
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

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost] // BİR BUTONA BASTIGIM ZAMAN HERHANGİ BİR ŞEY OLDUGU ZAMAN ÇALIŞMASI İÇİN KULLANIYORUZ. bir attiributestir 
        public ActionResult AddCategory(Category p)
        {
            cm.CategoryAddBL(p);
            return RedirectToAction("GetCatgoryList");
        }
        
        
    }
    }
