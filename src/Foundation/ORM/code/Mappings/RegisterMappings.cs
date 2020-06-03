using Aceto.XA.Foundation.ORM.GlassModels;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Maps;

namespace Aceto.Foundation.ORM.Mappings
{
    public class RegisterMappings : SitecoreGlassMap<IGlassBase>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.Info(f => f.BaseTemplateIds).InfoType(SitecoreInfoType.BaseTemplateIds);
            });
        }
    }
}