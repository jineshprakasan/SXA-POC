using Aceto.XA.Foundation.ORM.GlassModels;
using Glass.Mapper.Sc.Fields;

namespace Aceto.XA.Feature.Navigation.GlassModels
{
    public interface ISubNav : IGlassBase
    {
        string Title { get; set; }
        Image Icon { get; set; }
        Image ActiveIcon { get; set; }
    }
}
