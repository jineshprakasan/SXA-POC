using Aceto.XA.Feature.Navigation.GlassModels;
using Glass.Mapper.Sc.Maps;

namespace Aceto.XA.Feature.Navigation.Mappings
{
    public class NavigableMapping : SitecoreGlassMap<INavigable>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Templates.Navigation.ID);
                config.Field(item => item.Title).FieldId(Templates.Navigation.Fields.Title);
                config.Field(item => item.NavigationUrl).FieldId(Templates.Navigation.Fields.Url);
            });
        }
    }
}