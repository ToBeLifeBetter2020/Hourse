using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using ToBeLifeBetter.Hourse.Models;
using ToBeLifeBetter.IService;

namespace ToBeLifeBetter.Hourse.Controllers
{

    public class Model 
    {
        public int Age { get; set; }
    }
    public class HomeController : Controller
    {
        public IUserService userService { get; set; }

        
        public ActionResult Index(Model model)
        {
            if (ModelState.IsValid)
            {

            }
            else 
            {
                string error = MVCHelper.GetValidateMessage(ModelState);
                return Content(error);
            }

            return Content("");
        }

        public ActionResult About()
        {
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            var date = new { Time = DateTime.Now };
            string aa = javaScriptSerializer.Serialize(date);
            return Content(aa);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}