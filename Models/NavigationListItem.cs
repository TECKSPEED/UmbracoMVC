using System.Collections.Generic;
using System.Linq;

namespace PerfectAimBowling.Models
{
    public class NavigationListItem
    {
        public string Text { get; set; }
        public NavigationLink Link { get; set; }
        public List<NavigationListItem> Items { get; set; }
        public bool HasChildren { get { return Items != null && Items.Any() && Items.Count >= 0; } }

        public NavigationListItem(NavigationLink curLink)
        {
            Link = curLink;
        }

        public NavigationListItem(string curText)
        {
            Text = curText;
        }
    }
}