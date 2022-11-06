using SubhashTripathi_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubhashTripathi_Demo.Controllers
{
    public class CartController : Controller
    {
        DemoDbContext context = new DemoDbContext();
        // GET: Cart
        public ActionResult Index()
        {
            var products = context.products.Where(m => m.isDeleted == false).Select(m => m).ToList();
            return View(products);
        }

        
        public ActionResult Add( Product product  )
        {
            CartVM cartVM = new CartVM();
            cartVM.product = product;
            if (Session["cart"] == null)
            {
                cartVM.id = 1;
                List<CartVM> liCarts = new List<CartVM>(); 
                liCarts.Add(cartVM);
                Session["cart"] = liCarts;
                ViewBag.cart = liCarts.Count();
                Session["count"] = 1;
            }
            else
            {
                List<CartVM> liCarts = (List<CartVM>)Session["cart"];
                cartVM.id = Convert.ToInt32(Session["count"]) + 1;
                liCarts.Add(cartVM);
                Session["cart"] = liCarts;
                ViewBag.cart = liCarts.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;

            }
            return RedirectToAction("Index", "Cart");


        }
    }
}