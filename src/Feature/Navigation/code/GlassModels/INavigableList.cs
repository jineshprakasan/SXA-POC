using Aceto.XA.Foundation.ORM.GlassModels;
using System.Collections.Generic;

namespace Aceto.XA.Feature.Navigation.GlassModels
{
    public interface INavigableList : IGlassBase
    {
        IEnumerable<INavigable> NavigableItems { get; set; }
    }
}
