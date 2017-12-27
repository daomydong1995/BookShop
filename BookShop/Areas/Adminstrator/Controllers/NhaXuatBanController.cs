using BookShop.Model;
using BookShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Areas.Adminstrator.Controllers
{
    public class NhaXuatBanController : Controller
    {
        NhaXuatBanRepository nxbRepo = null;
        public NhaXuatBanController()
        {
            nxbRepo = new NhaXuatBanRepository();
        }

        public JsonResult List()
        {
            return Json(nxbRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }
        // GET: Adminstrator/NhaXuatBan
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(NHAXUATBAN nxb)
        {
            return Json(nxbRepo.Create(nxb), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(int id)
        {
            NHAXUATBAN nxb = nxbRepo.GetAll().SingleOrDefault(x => x.MaNXB == id);
            return Json(nxb, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update(NHAXUATBAN nxb)
        {
            return Json(nxbRepo.Update(nxb), JsonRequestBehavior.AllowGet);
        }
    }
}