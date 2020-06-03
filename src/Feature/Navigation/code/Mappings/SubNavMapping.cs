using Aceto.XA.Feature.Navigation.GlassModels;
using Glass.Mapper.Sc.Maps;

namespace Aceto.XA.Feature.Navigation.Mappings
{
    public class SubNavMapping : SitecoreGlassMap<ISubNav>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Templates.SubNav.ID);
                config.Field(item => item.Title).FieldId(Templates.SubNav.Fields.Title);
                config.Field(item => item.Icon).FieldId(Templates.SubNav.Fields.Icon);
                config.Field(item => item.ActiveIcon).FieldId(Templates.SubNav.Fields.ActiveIcon);
            });
        }
    }
}