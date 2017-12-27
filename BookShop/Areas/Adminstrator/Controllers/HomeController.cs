using BookShop.Model;
using BookShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Areas.Adminstrator.Controllers
{
    public class HomeController : Controller
    {
        adminRepository adminRepo = null;
        // GET: Adminstrator/Home

            public HomeController()
        {
            adminRepo = new adminRepository();
        }
        public ActionResult Index()
        {
            return View(adminRepo.GetAll());
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            ADMIN admin = adminRepo.GetAll().SingleOrDefault(x => x.username == username && x.password == password);
            if (admin!=null)
            {
                Session["userid"] = admin.userid;
                Session["username"] = admin.username;
                Session["fullname"] = admin.fullname;
                Session["avatar"] = admin.avatar;
                return RedirectToAction("Index");
            }
            ViewBag.error = "Sai tên đăng nhập haowjc mật lkhaaur";
            return View(); 
        }
    }
        
}