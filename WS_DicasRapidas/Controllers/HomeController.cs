using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WS_DicasRapidas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View("vwIndex");
        }

        public ViewResult ConsultarDicas(string a)
        {
            return View("vwConsultarDicas");
        }

        public ViewResult testeajax()
        {
            return View("ajax");
        }

        public ViewResult testecourse()
        {
            return View("vwCourseDetail");
        }
    }
}
