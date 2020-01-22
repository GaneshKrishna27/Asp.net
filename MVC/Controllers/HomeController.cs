using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult Mypage()
        {
            return Json(("{id:1,name:ganesh}"),JsonRequestBehavior.AllowGet);
        } 
        public ViewResult Mypage2()
        {
            return View();
        }
    }
}