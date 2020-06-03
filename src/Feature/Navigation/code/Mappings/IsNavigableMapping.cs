using Aceto.XA.Feature.Navigation.GlassModels;
using Glass.Mapper.Sc.Maps;

namespace Aceto.XA.Feature.Navigation.Mappings
{
    public class IsNavigableMapping : SitecoreGlassMap<IIsNavigable>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Templates.IsNavigable.ID);
                config.Field(item => item.IsNavigable).FieldId(Templates.IsNavigable.Fields.IsNavItem);
            });
        }
    }
}