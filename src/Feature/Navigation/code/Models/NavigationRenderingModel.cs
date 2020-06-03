using Sitecore.XA.Foundation.Mvc.Models;
using System.Collections.Generic;
using System.Web;

namespace Aceto.XA.Feature.Navigation.Models
{
    public class NavigationRenderingModel : RenderingModelBase
    {    
        public List<Navigation> Navigations { get; set; }
    }
}