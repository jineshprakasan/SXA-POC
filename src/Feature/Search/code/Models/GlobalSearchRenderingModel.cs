using Sitecore.XA.Foundation.Variants.Abstractions.Models;

namespace Aceto.XA.Feature.Search.Models
{
    public class GlobalSearchRenderingModel : VariantsRenderingModel
    {
        public string SearchTextBoxText { get; set; }

        public string SearchResultPageUrl { get; set; }
    }
}