using Sitecore.Globalization;
using System;
using System.Collections;

namespace Aceto.XA.Foundation.ORM.GlassModels
{
    public interface IGlassBase
    {
        Guid Id { get; set; }
        Language Language { get; set; }
        int Version { get; set; }
        IEnumerable BaseTemplateIds { get; set; }
        string TemplateName { get; set; }
        Guid TemplateId { get; set; }
        string Name { get; set; }
        string Url { get; set; }
        string DisplayName { get; set; }
    }
}
