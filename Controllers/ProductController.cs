using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SubhashTripathi_Demo.Models;

namespace SubhashTripathi_Demo.Controllers
{
    public class ProductController : Controller
    {
        DemoDbContext context = new DemoDbContext();
        // GET: Product
        public ActionResult Index()
        {
            var products = context.products.Where(m => m.isDeleted == false).Select(m => m).ToList();

            return View(products);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Post(Product product, HttpPostedFileBase file)
        {
                if(file != null)
                {
                    bool status = allowedExtensions(file);
                    if (status)
                    {
                        string fileName = GetImagePath(file);
                        product.image = fileName;
                        product.isDeleted = false;
                        context.products.Add(product);
                        context.SaveChanges();
                    }
                }
            
         
            return RedirectToAction("Index");
        }

        public bool allowedExtensions(HttpPostedFileBase file)
        {
            var allowedExtensions = new[] {
                            ".Jpg", ".png", ".jpg", "jpeg"
                        };
            var fileName = Path.GetFileName(file.FileName);
            var ext = Path.GetExtension(file.FileName);
            if (allowedExtensions.Contains(ext))
            {
                return true;
            }
            return false;

        }
        public string GetImagePath(HttpPostedFileBase file)
        {
            string imageName = "";
            string myfile = file.FileName;
            var path = Path.Combine(Server.MapPath("~/Image"), myfile);
            imageName = "~/Image/" + myfile;
            file.SaveAs(path);
            return imageName;
        }
        public ActionResult Delete(int id)
        {
            var product = context.products.Find(id);
            product.isDeleted = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}