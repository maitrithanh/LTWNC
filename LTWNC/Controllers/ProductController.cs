using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTWNC.Models;
namespace LTWNC.Controllers
{
    public class ProductController : Controller
    {
        LTWNCEntities1 database = new LTWNCEntities1();
        // GET: Product
        public ActionResult Shop(int? page, string SearchString = "")
        {
            int pageSize = 4;
            int pageNum = (page ?? 1);
            if (SearchString != "")
            {
                var listProducts = database.SANPHAMs.Where(s => s.TENSP.Contains(SearchString)).ToList();
                return View(listProducts.ToPagedList(pageNum, pageSize));
            }
            else
            {
                var listProducts = database.SANPHAMs.OrderByDescending(sp => sp.TENSP).ToList();
                return View(listProducts);
            }
        }
    }
}