using Aceto.XA.Foundation.ORM.GlassModels;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System.Collections.Generic;

namespace Aceto.XA.Feature.Navigation.GlassModels
{
    public interface INavigable : IGlassBase
    {
        string Title { get; set; }
        Link NavigationUrl { get; set; }

        [SitecoreChildren(InferType = true)]
        IEnumerable<INavigable> Children { get; set; }
    }
}
