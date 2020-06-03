using Aceto.XA.Foundation.ORM.GlassModels;

namespace Aceto.XA.Feature.Navigation.GlassModels
{
    public interface IIsNavigable : IGlassBase
    {
        bool IsNavigable { get; set; }
    }
}
