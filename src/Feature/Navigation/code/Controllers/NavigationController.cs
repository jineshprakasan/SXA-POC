using Aceto.XA.Feature.Navigation.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace Aceto.XA.Feature.Navigation.Controllers
{
    public class NavigationController : StandardController
    {
        public INavigationRepository navigationRepository { get; set; }

        public NavigationController(INavigationRepository navigationRepositoryObj)
        {
            this.navigationRepository = navigationRepositoryObj;
        }
        // GET: GlobalSearch
        protected override object GetModel()
        {
            return (object)navigationRepository.GetModel();
        }
    }
}