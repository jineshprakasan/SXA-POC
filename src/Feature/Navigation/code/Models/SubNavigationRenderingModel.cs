using Sitecore.XA.Foundation.Mvc.Models;
using System.Collections.Generic;

namespace Aceto.XA.Feature.Navigation.Models
{
    public class SubNavigationRenderingModel: RenderingModelBase
    {
        public string CurrentItem { get; set; }
        public List<SubNavItem> SubNavItems { get; set; }
    }
}