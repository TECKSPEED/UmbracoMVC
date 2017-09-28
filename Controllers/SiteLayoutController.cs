using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;
using PerfectAimBowling.Models;
using Umbraco.Web;

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
            List<NavigationListItem> nav = GetNavigationDynamically();
            return PartialView(LAYOUT_DIRECTORY + "_Navigation.cshtml", nav);
        }

        /// <summary>
        /// Finds the home page and gets the navigation structure based on it and it's children
        /// </summary>
        /// <returns>A List of NavigationListItems, representing the structure of the site.</returns>
        private List<NavigationListItem> GetNavigationDynamically()
        {
            var homePage = Umbraco.TypedContentAtRoot();
            IPublishedContent homeNode = CurrentPage.AncestorOrSelf(1);
            List<NavigationListItem> nav = new List<NavigationListItem>();
            nav.Add(new NavigationListItem(new NavigationLink(homeNode.Url, homeNode.Name)));
            nav.AddRange(GetChildNavigationList(homeNode));

            return nav;

        }

        /// <summary>
        /// Loops through the child pages of a given page and their children to get the structure of the site.
        /// </summary>
        /// <param name="page">The parent page which you want the child structure for</param>
        /// <returns>A List of NavigationListItems, representing the structure of the pages below a page.</returns>
        private List<NavigationListItem> GetChildNavigationList(dynamic page)
        {
            List<NavigationListItem> listItems = null;
            var childPages = page.Children;
            if (childPages != null && childPages.Count > 0)
            {
                listItems = new List<NavigationListItem>();
                foreach (var childPage in childPages)
                {
                    NavigationListItem listItem = new NavigationListItem(new NavigationLink(childPage.Url, childPage.Name));
                    listItem.Items = GetChildNavigationList(childPage);
                    listItems.Add(listItem);
                }
            }
            return listItems;
        }
    }
}