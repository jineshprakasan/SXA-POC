using Aceto.XA.Feature.Search.Controllers;
using Aceto.XA.Feature.Search.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Aceto.XA.Feature.Search.DI
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IGlobalSearchRepository, GlobalSearchRepository>();
            serviceCollection.AddTransient<GlobalSearchController>();
        }
    }
}