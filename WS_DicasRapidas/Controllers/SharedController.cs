using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WS_DicasRapidas.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult testeModal()
        {
            return View("testeModal");
        }
    }
}