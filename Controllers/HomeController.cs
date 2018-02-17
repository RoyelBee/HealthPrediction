using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthPrediction.Controllers
{
    public class HomeController : Controller
    {

        //[Authorize]
        public ActionResult Index()
        {
            if (User.IsInRole("CanManagePatient"))
                return View("AdminPage");
            else if (User.IsInRole("PatientRole"))
            {
                return View("PatientPage");
            }
            
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