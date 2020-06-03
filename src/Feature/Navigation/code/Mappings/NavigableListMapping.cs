using Aceto.XA.Feature.Navigation.GlassModels;
using Glass.Mapper.Sc.Maps;

namespace Aceto.XA.Feature.Navigation.Mappings
{
    public class NavigableListMapping : SitecoreGlassMap<INavigableList>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Templates.NavigationList.ID);
                config.Children(item => item.NavigableItems);
            });
        }
    }
}