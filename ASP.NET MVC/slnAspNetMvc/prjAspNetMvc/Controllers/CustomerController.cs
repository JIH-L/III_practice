using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjAspNetMvc.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult List()
        {
            var customers = from t in (new dbDemoEntities()).tCustomer
                            select t;
            return View(customers);
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Save()
        {
            tCustomer x = new tCustomer();
            x.fAddress = Request.Form["txtAddress"];
            x.fBirthday = Request.Form["txtBirthday"];
            x.fName = Request.Form["txtName"];
            x.fPassword = Request.Form["txtPassword"];
            x.fPhone = Request.Form["txtPhone"];

            dbDemoEntities db = new dbDemoEntities();
            db.tCustomer.Add(x);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult Delete(int? id)
        {
            if (id==null)
                return RedirectToAction("List");
            dbDemoEntities db = new dbDemoEntities();
            tCustomer x = db.tCustomer.FirstOrDefault(m => m.fId == id);
            if (x != null)
            {
                db.tCustomer.Remove(x);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("List");

            dbDemoEntities db = new dbDemoEntities();
            tCustomer x = db.tCustomer.FirstOrDefault(m => m.fId == id);
            
            return View(x);
        }
        
        [HttpPost] // 動作選取器
        public ActionResult Edit(tCustomer p)
        {
            dbDemoEntities db = new dbDemoEntities();
            tCustomer cust = db.tCustomer.FirstOrDefault(m => m.fId == p.fId);
            if(cust != null)
            {
                cust.fName = p.fName;
                cust.fPhone = p.fPhone;
                cust.fPassword = p.fPassword;
                cust.fAddress = p.fAddress;
                cust.fBirthday = p.fBirthday;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }



        public ActionResult sumDemo()
        {
            string s1 = Request.Form["txtA"];
            string s2 = Request.Form["txtB"];
            ViewBag.sum = "?";
            if (!string.IsNullOrEmpty(s1))
            {
                int a = Convert.ToInt32(s1);
                int b = Convert.ToInt32(s2);
                ViewBag.sum = (a + b).ToString();
            }
            return View();
        }
        public ActionResult progDemo()
        {
            //string s1 = Request.Form["txtA"];
            //string s2 = Request.Form["txtB"];
            //string s3 = Request.Form["txtC"];
            //ViewBag.xx = "0";
            //ViewBag.yy = "0";
            //if (!string.IsNullOrEmpty(s1))
            //{
            //    int a = Convert.ToInt32(s1);
            //    int b = Convert.ToInt32(s2);
            //    int c = Convert.ToInt32(s3);
            //    int z = b * b - 4 * a * c;

            //    ViewBag.xx = ((-b + Math.Sqrt(z)) / 2 * a).ToString("0.00");
            //    ViewBag.yy = ((-b - Math.Sqrt(z)) / 2 * a).ToString("0.00");
            //}
            ViewBag.KK = "X = ?";
            if (!string.IsNullOrEmpty(Request.Form["txtA"]))
            {
                double a = Convert.ToDouble(Request.Form["txtA"]);
                double b = Convert.ToDouble(Request.Form["txtB"]);
                double c = Convert.ToDouble(Request.Form["txtC"]);
                double r = b * b - 4 * a * c;
                r = Math.Sqrt(r);

                ViewBag.KK = "X=" + ((-b + r) / (2 * a)).ToString("0.00") + "Or X=" + ((-b - r) / (2 * a)).ToString("0.00");
            }

            return View();
        }
    }
}