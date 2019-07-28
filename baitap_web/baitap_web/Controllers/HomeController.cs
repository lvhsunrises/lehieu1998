using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap_web.Controllers
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

        public ActionResult Myteam()
        {
            return View();
        }

        public ActionResult Officialform1All()
        {
            return View();
        }


        public ActionResult Officialform2All()
        {
            return View();
        }

        public ActionResult Profile1()
        {
            return View();
        }

        public ActionResult Profile2()
        {
            return View();
        }

    }
}