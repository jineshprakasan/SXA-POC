using Aceto.XA.Feature.Navigation.Controllers;
using Aceto.XA.Feature.Navigation.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Aceto.XA.Feature.Navigation.DI
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<INavigationRepository, NavigationRepository>();
            serviceCollection.AddTransient<ISubNavigationRepository, SubNavigationRepository>();
            serviceCollection.AddTransient<NavigationController>();
            serviceCollection.AddTransient<SubNavigationController>();
        }
    }
}