using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
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

        [HttpGet]
        public ActionResult Get_State2(string postcode)
        {

            string result = "";
            var buffer = "";
            var nyeeez = "";
            var nyez3 = "baka";
            var nyez4 = "oh my";
            var nyeeeez5 = "jesus";
            var jesus1 = "boyyy";
            var jesus2 = "";
            var jesus3 = "";
            var j4 = "";

            if (postcode != "" && postcode != null)
            {

                buffer = "1234";

            }


            return Json(result, JsonRequestBehavior.AllowGet);

        }
    }
}