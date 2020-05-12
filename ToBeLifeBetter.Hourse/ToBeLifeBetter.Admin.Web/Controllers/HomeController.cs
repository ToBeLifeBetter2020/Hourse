using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToBeLifeBetter.Admin.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //if (Session["Id"] != null)
            //{
            //    return Content(Session["Id"].ToString());
            //}
            //else
            //{
            //    Session["Id"] = "123";
            //}

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
    }
}