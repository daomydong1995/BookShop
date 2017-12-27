using BookShop.Model;
using BookShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Controllers
{
    public class SachController : Controller
    {
        ChuDeRepository chudeRepo = null;
        SachRepository sachRepo = null;
        public SachController()
        {
            chudeRepo = new ChuDeRepository();
            sachRepo = new SachRepository();
        }
        // GET: Sach
        public ActionResult Index(int? id)
        {
            return View(sachRepo.GetAll().Where(x => x.MaCD == id).ToList());
        }

        public ActionResult PartialViewCate()
        {
            return PartialView(chudeRepo.GetAll());
        }

        public ActionResult Details(int id)
        {
            return View(sachRepo.GetById(id));
        }

        public ActionResult Search(string search)
        {
            List<SACH> listSach = new List<SACH>();
            listSach = sachRepo.GetAll().Where(x => x.Tensach.ToLower().Contains(search.ToLower())).ToList();
            return View(listSach);
        }
        
    }
}