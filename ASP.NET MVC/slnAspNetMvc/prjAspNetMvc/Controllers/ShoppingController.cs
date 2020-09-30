using prjAspNetMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjAspNetMvc.Controllers
{
    public class ShoppingController : Controller
    {
        // GET: Shopping
        public ActionResult List()
        {
            var products = from p in (new dbDemoEntities()).tProduct
                           select p;
            return View(products);
        }

        public ActionResult CartView()
        {
            List<tShoppingCart> list = Session[CDictionary.SK_PRODUCTS_PUTED_IN_SHOPPINGCART] as List<tShoppingCart>;
            if (list == null)
                return RedirectToAction("List");
            dbDemoEntities db = new dbDemoEntities();
            //foreach(tShoppingCart t in list)
            //{
            //    tProduct p =db.tProduct.FirstOrDefault t.fProductId
            //}

            return View(list);

        }
        public ActionResult AddToCart(int id)
        {
            return View(id);
            
        }
        public ActionResult AddToSession(int id)
        {
            return View(id);

        }
        [HttpPost] // 動作選取器
        public ActionResult AddToCart()
        {
            string id = Request.Form["txtFid"];
            if (string.IsNullOrEmpty(id))
                return RedirectToAction("List");

            int fId = Convert.ToInt32(id);
            dbDemoEntities db = new dbDemoEntities();
            tProduct product = db.tProduct.FirstOrDefault(p => p.fId == fId);
            if (product == null)
                return RedirectToAction("List");
            tShoppingCart item = new tShoppingCart();
            item.fDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            item.fCustomerId = 1;
            item.fProductId = product.fId;
            item.fPrice = product.fPrice;
            item.fCount = Convert.ToInt32(Request.Form["txtCount"]);

            db.tShoppingCart.Add(item);
            db.SaveChanges();
            return RedirectToAction("List");
            
        }
        [HttpPost] // 動作選取器
        public ActionResult AddToSession()
        {
            string id = Request.Form["txtFid"];
            if (string.IsNullOrEmpty(id))
                return RedirectToAction("List");

            int fId = Convert.ToInt32(id);
            dbDemoEntities db = new dbDemoEntities();
            tProduct product = db.tProduct.FirstOrDefault(p => p.fId == fId);
            if (product == null)
                return RedirectToAction("List");

            List<tShoppingCart> list = Session[CDictionary.SK_PRODUCTS_PUTED_IN_SHOPPINGCART] as List<tShoppingCart>;
            if(list == null)
            {
                list = new List<tShoppingCart>();
                Session[CDictionary.SK_PRODUCTS_PUTED_IN_SHOPPINGCART] = list;
            }

            tShoppingCart item = new tShoppingCart();
            item.fDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            item.fCustomerId = 1;
            item.fProductId = product.fId;
            item.fPrice = product.fPrice;
            item.fCount = Convert.ToInt32(Request.Form["txtCount"]);
            list.Add(item);
            
            return RedirectToAction("List");

        }
    }
}