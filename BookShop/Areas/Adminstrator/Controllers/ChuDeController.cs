using BookShop.Model;
using BookShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace BookShop.Areas.Adminstrator.Controllers
{
    public class ChuDeController : Controller
    {

        ChuDeRepository chuDeRepo = null;
        public ChuDeController()
        {
            chuDeRepo = new ChuDeRepository();
        }

        // GET: Adminstrator/ChuDe
        public ActionResult Index()
        {
            //var listChuDe = chuDeRepo.GetAll();
            //return View(listChuDe);

            return View();
        }

        //Phân trang
        public PartialViewResult Getpaging(int? page)
        {
            int pageSize = 5; //số phần từ 1 trang
            int pageNumber = (page ?? 1);// số trang
            return PartialView("_PartialViewChuDe", chuDeRepo.GetAll().ToPagedList(pageNumber, pageSize));


        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CHUDE cd)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    chuDeRepo.Create(cd);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(cd);
        }

        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                chuDeRepo.Delete((int)id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                throw;
            }
            return RedirectToAction("Index");
        }
    }
}