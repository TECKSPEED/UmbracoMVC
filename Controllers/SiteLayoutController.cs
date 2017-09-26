using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace PerfectAimBowling.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        public const string LAYOUT_DIRECTORY = "~/Views/Partials/SiteLayout/";

        public ActionResult RenderHeader()
        {
            return PartialView(LAYOUT_DIRECTORY + "_Header.cshtml");
        }

        public ActionResult RenderFooter()
        {
            return PartialView(LAYOUT_DIRECTORY + "_Footer.cshtml");
        }

        public ActionResult RenderNavigation()
        {
            return PartialView(LAYOUT_DIRECTORY + "_Navigation.cshtml");
        }

    }
}