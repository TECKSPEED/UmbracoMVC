using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerfectAimBowling.Models
{
    public class NavigationLink
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public string Target { get { return NewWindow ? "_blank" : null; } }
        public string Title { get; set; }
        public bool NewWindow { get; set; }

        public NavigationLink(string url, string text = null, string title = null, bool newWindow = false)
        {
            Text = text;
            Url = url;
            Title = title;
            NewWindow = newWindow;
        }
    }
}