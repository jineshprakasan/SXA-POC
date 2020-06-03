using Aceto.XA.Feature.Navigation.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace Aceto.XA.Feature.Navigation.Controllers
{
    public class SubNavigationController : StandardController
    {
        public ISubNavigationRepository subNavigationRepository { get; set; }

        public SubNavigationController(ISubNavigationRepository subNavigationRepositoryObj)
        {
            this.subNavigationRepository = subNavigationRepositoryObj;
        }
        // GET: GlobalSearch
        protected override object GetModel()
        {
            return (object)subNavigationRepository.GetModel();
        }
    }
}