using System.Collections.Generic;
using System.Web;

namespace Aceto.XA.Feature.Navigation.Models
{
    public class Navigation
    {
        public bool IsActive { get; set; }
        public HtmlString NavigationTitle { get; set; }
        public string NavigationUrl { get; set; }
        public List<Navigation> Navigations { get; set; }
    }
}