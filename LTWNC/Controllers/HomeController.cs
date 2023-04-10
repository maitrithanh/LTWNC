using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTWNC.Models;

namespace LTWNC.Controllers
{
    public class HomeController : Controller
    {
        LTWNCEntities1 database = new LTWNCEntities1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(CONTACT ct)
        {
            database.CONTACTs.Add(ct);
            database.SaveChanges();
            return View();
        }
    }
}