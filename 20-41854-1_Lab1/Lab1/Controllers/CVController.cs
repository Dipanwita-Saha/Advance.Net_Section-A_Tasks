using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult Index()
        {
            ViewBag.Message = "Wellcome to your Profile";
            return View();
        }
        public ActionResult Person()
        {
            ViewBag.Message = "Personal Background";

            return View();
        }
        public ActionResult Project()
        {
            ViewBag.Message = "Previous Projects";

            return View();
        }
        public ActionResult Edu()
        {
            ViewBag.Message = "Educational Level";

            return View();
        }
        public ActionResult Ref()
        {
            ViewBag.Message = "References";

            return View();
        }
    }
}