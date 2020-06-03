using Aceto.XA.Feature.Search.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace Aceto.XA.Feature.Search.Controllers
{
    public class GlobalSearchController : StandardController
    {
        public IGlobalSearchRepository globalSearchRepository { get; set; }

        public GlobalSearchController(IGlobalSearchRepository globalSearchRepositoryObj)
        {
            this.globalSearchRepository = globalSearchRepositoryObj;// ServiceLocator.ServiceProvider.GetService<IGlobalSearchRepository>();
        }
        // GET: GlobalSearch
        protected override object GetModel()
        {
            return (object)globalSearchRepository.GetModel();
        }
    }
}