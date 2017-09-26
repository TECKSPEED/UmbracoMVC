using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace PerfectAimBowling.Controllers
{
    public class HomeController : SurfaceController
    {

        public const string LAYOUT_DIRECTORY = "~/Views/Partials/Home/";

        public ActionResult RenderFeatured()
        {
            return PartialView(LAYOUT_DIRECTORY + "_HomeFeatured.cshtml");
        }

        public ActionResult RenderVideoFeatured()
        {
            return PartialView(LAYOUT_DIRECTORY + "_HomeVideoFeatured.cshtml");
        }

        public ActionResult RenderServicesFeatured()
        {
            return PartialView(LAYOUT_DIRECTORY + "_HomeServicesFeatured.cshtml");
        }

        public ActionResult RenderTestimonialsFeatured()
        {
            return PartialView(LAYOUT_DIRECTORY + "_HomeTestimonialsFeatured.cshtml");
        }

        public ActionResult RenderStatisticsFeatured()
        {
            return PartialView(LAYOUT_DIRECTORY + "_HomeStatisticsFeatured.cshtml");
        }
    }
}