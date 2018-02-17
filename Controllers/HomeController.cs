using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthPrediction.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            if (User.IsInRole("CanManagePatient"))
                return View("AdminPage");

            return View("PatientPage");
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