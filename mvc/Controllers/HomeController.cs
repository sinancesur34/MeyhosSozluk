using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using sehirler_cascading.Models;

namespace sehirler_cascading.Controllers
{
    public class HomeController : Controller
    {
        public KayipDB db = new KayipDB();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //DenemeEntities db = new DenemeEntities();
        Class1 cs = new Class1();
        public ActionResult Deneme()
        {
            cs.Sehirler = new SelectList(db.tbliller, "id", "ad");
            cs.ilceler = new SelectList(Enumerable.Empty<SelectListItem>());
            return View(cs);
        }
        public ActionResult ilcegetir(int p)
        {
            var ilceler = (from x in db.Tblilceler
                           join y in db.tbliller on x.ilid equals y.id
                           where x.tbliller.id == p
                           select new
                           {
                               Text = x.ad,
                               value = x.id
                           }).ToList();

            var ilceList = db.Tblilceler
                .Where(x => x.ilid == p)
                .Select(x => new {
                    Text = x.ad,
                    value = x.id
                }).ToList();
            ilceList.Insert(0, new
            {
                Text = "Lütfen Seçiniz",
                value = 0
            });

            return Json(ilceList, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Kayipilan()
        {


            cs.Sehirler = new SelectList(db.tbliller, "id", "ad");
            cs.ilceler = new SelectList(Enumerable.Empty<SelectListItem>());
            return View(cs);
        }
    }
}