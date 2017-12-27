using BookShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Areas.Adminstrator.Controllers
{
    public class SachController : Controller
    {
        ChuDeRepository chudeRepo = null;
        NhaXuatBanRepository nxbRepo = null;
        SachRepository sachRepo = null;
        // GET: Adminstrator/Sach

        public SachController()
        {
            chudeRepo = new ChuDeRepository();
            nxbRepo = new NhaXuatBanRepository();
            sachRepo = new SachRepository();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.maCD = new SelectList(chudeRepo.GetAll(), "MaCD", "Tenchude");
            ViewBag.MaNXB = new SelectList(nxbRepo.GetAll(), "MaNXB", "TenNXB");
            return View();
        }
    }
}