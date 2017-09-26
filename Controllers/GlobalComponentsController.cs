using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace PerfectAimBowling.Controllers
{
    public class GlobalComponentsController : SurfaceController
    {
        public const string LAYOUT_DIRECTORY = "~/Views/Partials/";

        public ActionResult RenderSubscribe()
        {
            return PartialView(LAYOUT_DIRECTORY + "_Subscribe.cshtml");
        }
    }
}