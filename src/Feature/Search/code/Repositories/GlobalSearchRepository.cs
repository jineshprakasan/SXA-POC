using Aceto.XA.Feature.Search.Models;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace Aceto.XA.Feature.Search.Repositories
{
    public class GlobalSearchRepository : ModelRepository, IGlobalSearchRepository
    {

        public override IRenderingModelBase GetModel()
        {

            GlobalSearchRenderingModel globalSearchRenderingModel = new GlobalSearchRenderingModel();
            this.FillBaseProperties((object)globalSearchRenderingModel);
            globalSearchRenderingModel.SearchTextBoxText = this.Rendering.DataSourceItem != null ? ((BaseItem)this.Rendering.DataSourceItem).Fields[Templates.GlobalSearch.Fields.TextBoxText].GetValue(true) : "Search here...";
            globalSearchRenderingModel.SearchResultPageUrl = this.GetSearchResultPageUrl();
            return (IRenderingModelBase)globalSearchRenderingModel;
        }
        protected virtual string GetSearchResultPageUrl()
        {
            string parameter = this.Rendering.Parameters["SearchResultPage"];
            return ID.IsID(parameter) ? LinkManager.GetItemUrl(this.Context.Database.GetItem(new ID(parameter))) : string.Empty;
        }
    }
}