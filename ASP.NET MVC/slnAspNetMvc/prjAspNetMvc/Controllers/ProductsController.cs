using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjAspNetMvc.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult List()
        {
            IQueryable<tProduct> products = null;
            string keyword = Request.Form["txtKeyword"];
            if (string.IsNullOrEmpty(keyword))
            {
                products = from p in (new dbDemoEntities()).tProduct
                           select p;
            }
            else
            {
                products = from p in (new dbDemoEntities()).tProduct
                           where p.fName.Contains(keyword)
                           select p;
            }

            return View(products);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost] // 動作選取器
        public ActionResult Create(tProduct p)
        {
            if (p.fImage != null)
            {
                string photoName = Guid.NewGuid().ToString()+Path.GetExtension(p.fImage.FileName);

                var path = Path.Combine(Server.MapPath("~/Content/"), photoName);
                p.fImage.SaveAs(path);
                p.fImagPath = "../Content/"+ photoName;
            }

            dbDemoEntities db = new dbDemoEntities();
            db.tProduct.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return RedirectToAction("List");
            dbDemoEntities db = new dbDemoEntities();
            tProduct p = db.tProduct.FirstOrDefault(m => m.fId == id);
            if (p != null)
            {
                db.tProduct.Remove(p);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("List");

            dbDemoEntities db = new dbDemoEntities();
            tProduct x = db.tProduct.FirstOrDefault(m => m.fId == id);

            return View(x);
        }

        [HttpPost] // 動作選取器
        public ActionResult Edit(tProduct p)
        {
            if (string.IsNullOrEmpty(p.fName))
                return RedirectToAction("List");
            dbDemoEntities db = new dbDemoEntities();
            tProduct cust = db.tProduct.FirstOrDefault(m => m.fId == p.fId);
            if (cust != null)
            {
                cust.fName = p.fName;
                cust.fQty = p.fQty;
                cust.fCost = p.fCost;
                cust.fImagPath = p.fImagPath;
                cust.fPrice = p.fPrice;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        
    }
}