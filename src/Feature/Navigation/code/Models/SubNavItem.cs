using System.Web;

namespace Aceto.XA.Feature.Navigation.Models
{
    public class SubNavItem
    {
        public HtmlString Title { get; set; }
        public HtmlString Icon { get; set; }
        public HtmlString ActiveIcon { get; set; }
        public string Url { get; set; }
    }
}