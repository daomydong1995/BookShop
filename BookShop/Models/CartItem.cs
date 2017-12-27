using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    public class CartItem
    {
        public SACH ProductOrder { get; set; }
        public int Quantity { get; set; }
    }
}