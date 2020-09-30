using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjAspNetMvc.Controllers
{
    public class AController : Controller
    {
        // GET: A
        public ActionResult countMeByCookie()
        {
            // cookie 只存在客戶端
            int count = 0;
            HttpCookie cookie = Request.Cookies["KK"];
            if (cookie != null)
            {
                count = Convert.ToInt32(cookie.Value);
                //cookie.Expires = DateTime.Now.AddSeconds(-1);
                //Response.Cookies.Remove("KK");
            }
            count++;
            
            cookie = new HttpCookie("KK");
            cookie.Value = count.ToString();
            cookie.Expires = DateTime.Now.AddSeconds(20); // cookie期限
            Response.Cookies.Add(cookie);
            ViewBag.countMe = count;
            return View();
        }

        public ActionResult countMeBySession()
        {
            // Session[key]
            // 1.使用key.value
            // 2.可接受obj
            // 3.SessionID
            // 4.只存在20分鐘

            int count = 0;
            if (Session["KK"] != null)
            {
                count = (int)Session["KK"];
            }
            count++;
            Session["KK"] = count;
            ViewBag.countMe = count;
            return View();
        }

        public ActionResult countMe()
        {
            int count = 0;
            if(!string.IsNullOrEmpty(Request.Form["KK"]))
            {
                count = Convert.ToInt32(Request.Form["KK"]);
            }
            count++;
            ViewBag.countMe = count;
            return View();
        }


        // 強型別物件繫結

        public ActionResult bindingCustomerById(int? fId)
        {
            tCustomer x = (new dbDemoEntities()).tCustomer.FirstOrDefault(m => m.fId == fId);
            
            return View(x);
        }

        // 弱型別資料傳遞

        //public ActionResult showCustomerById(int? fId)
        //{
        //    tCustomer x = (new dbDemoEntities()).tCustomer.FirstOrDefault(m => m.fId == fId);
        //    ViewBag.customer = x;
        //    //ViewBag.KK = "查無客戶資料";
        //    ViewBag.Img = "anonymous.jpg";
        //    if (x != null)
        //    {
        //        ViewBag.Img = x.fId.ToString() + ".jpg";
        //        //ViewBag.KK = x.fName;
        //        //ViewBag.JJ = x.fPhone;
        //    }
        //    return View();
        //}

        // 自己寫的QQ 取 1 - 50 數字 6 個不重複
        //public string getNumber()
        //{
        //    Random r = new Random(Guid.NewGuid().GetHashCode());
        //    int[] ar = new int[6];
        //    string sum = "";
        //    for (int i = 0; i < 6; i++)
        //    {
        //        ar[i] = r.Next(1, 50);
        //    }
        //    Array.Sort(ar);
        //    foreach(int z in ar)
        //    {
        //        sum += z.ToString()+", ";
        //    }
        //    return sum;
        //}

        // 取 1 - 50 數字 6 個不重複
        [NonAction]
        public string getNumber()
        {
            return new CLotto().getNumbers();
        }

        public string getCustomerById(int? fId)
        {
            tCustomer x = (new dbDemoEntities()).tCustomer.FirstOrDefault(m => m.fId == fId);
            if (x == null)
                return "查無客戶資料";
            return x.fName + "<br>" + x.fPhone;
        }

        // 檔案下載
        public string download()
        {
            Response.Clear();

            Response.ContentType = "application/octet-stream";
            Response.Filter.Close();
            Response.WriteFile(@"C:\QNote\dbQuickNote.7z");
            Response.End();

            return "您的下載已經開始...";
        }

        public string getQueryString()
        {
            string data = Request.QueryString["id"];
            return "您指定的資料是" + data;
        }

        // 所在路徑
        public string whereAmI()
        {
            return Server.MapPath(".");
        }


        // 圖片上傳
        public ActionResult fileUploadDemo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult fileUploadDemo(HttpPostedFileBase txtPhoto)
        {
            if(txtPhoto != null)
            {
                string name = Path.GetFileName(txtPhoto.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/"), name);
                txtPhoto.SaveAs(path);
            }
            return View();
        }
    }
}