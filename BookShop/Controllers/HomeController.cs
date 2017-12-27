using BookShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        SachRepository sachRepo = null;

        public HomeController()
        {
            sachRepo = new SachRepository();
        }
        public ActionResult Index()
        {
            ViewBag.SachMoi = sachRepo.GetAll().OrderByDescending(x => x.Ngaycapnhat).Take(4).ToList();
            ViewBag.SachBanChay = sachRepo.GetAll().OrderByDescending(x => x.Soluongban).Take(4).ToList();
            ViewBag.Hinhminhhoa = sachRepo.GetAll().OrderByDescending(x => x.Hinhminhhoa).Take(4);
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
        public JsonResult AutoComplete(string key)
        {
            var result = (from s in sachRepo.GetAll().ToList()
                          where s.Tensach.ToLower().StartsWith(key.ToLower())
                          select new
                          {

                              s.Tensach

                          });
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    } 
}