using prjAspNetMvc.Models;
using prjAspNetMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjAspNetMvc.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public ActionResult Home()
        {
            if (Session[CDictionary.SK_LOGEDIN_CUSTOMER] == null)
                return RedirectToAction("Login");
            return View();
        }
        public ActionResult Login()
        {
            string code = Session[CDictionary.SK_AUTHTUCATION_CODE] as string;
            if (string.IsNullOrEmpty(code))
            {
                Random r = new Random();
                code = r.Next(0,10).ToString()+r.Next(0,10).ToString()+r.Next(0,10).ToString()+r.Next(0, 10).ToString();
                Session[CDictionary.SK_AUTHTUCATION_CODE] = code;
            }
            ViewBag.CODE = code;
            return View();
        }

        [HttpPost]
        public ActionResult Login(CLogin p)
        {
            string code = Session[CDictionary.SK_AUTHTUCATION_CODE] as string;
            if (!p.txtCode.Equals(code))
            {
                ViewBag.CODE = code;
                return View();
            }
            int fId = Convert.ToInt32(p.txtAccount);
            tCustomer cust = (new dbDemoEntities()).tCustomer.FirstOrDefault(t => t.fId == fId && t.fPassword.Equals(p.txtPassword));
            if (cust == null)
                return View();

            Session[CDictionary.SK_LOGEDIN_CUSTOMER] = cust;
            return RedirectToAction("Home");
        }
    }
}