using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubhashTripathi_Demo.Controllers
{
    public class MyCartController : Controller
    {
        // GET: MyCart
        public ActionResult Index()
        {
            var obj = Session["cart"];
            return View(obj);
        }

        public ActionResult Remove(int id)
        {
            List<CartVM> li = (List<CartVM>)Session["cart"];
            li.RemoveAll(x => x.id == id);
            Session["cart"] = li;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            return RedirectToAction("Index", "MyCart");
        }
    }
}