using BookShop.Models;
using BookShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Controllers
{
    public class CartController : Controller
    {
        SachRepository sachRepo=null;
        public CartController()
        {
            sachRepo = new SachRepository();
        }
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddToCart (int id)
        {
            List<CartItem> giohang = null;
            if (Session["giohang"] == null)
            {
                giohang = new List<CartItem>();
                giohang.Add(new CartItem() { ProductOrder = sachRepo.GetById(id), Quantity = 1 });

            }
            else
            {
                giohang = Session["giohang"] as List<CartItem>;
                CartItem s = giohang.SingleOrDefault(x => x.ProductOrder.Masach == id);
                if(s!= null)
                {
                    s.Quantity++;
                }
                else
                {
                    giohang.Add(new CartItem()
                    {
                        ProductOrder = sachRepo.GetById(id),
                        Quantity = 1
                    });
                   
                }
            }
            Session["giohang"] = giohang;
            return Json(new { ItemAmount = giohang.Sum(x => x.Quantity) });

        }
    }
}