using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerfectAimBowling.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult RenderServices()
        {
            return View();
        }
    }
}