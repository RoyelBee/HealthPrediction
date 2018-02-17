using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthPrediction.Models;

namespace HealthPrediction.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient

        [Authorize(Roles = RoleName.CanManagePatient)]
        public ActionResult UpdatePatient()
        {
            return View();
        }
        public ActionResult PatientProfile()
        {
            return View();
        }
        public ActionResult CheckDisease()
        {
            return View();
        }
    }
}