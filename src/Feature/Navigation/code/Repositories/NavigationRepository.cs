using Aceto.XA.Feature.Navigation.GlassModels;
using Aceto.XA.Feature.Navigation.Models;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aceto.XA.Feature.Navigation.Repositories
{
    public class NavigationRepository : ModelRepository, INavigationRepository
    {
        private readonly IMvcContext mvcContext;
        public NavigationRepository(IMvcContext mvcContextObj)
        {
            mvcContext = mvcContextObj;
        }
        public override IRenderingModelBase GetModel()
        {
            NavigationRenderingModel navigationRenderingModel = new NavigationRenderingModel();
            this.FillBaseProperties((object)navigationRenderingModel);
            INavigableList navigableList = mvcContext.GetDataSourceItem<INavigableList>();
            if (navigableList != null && navigableList.NavigableItems != null && navigableList.NavigableItems.Any())
            {
                navigationRenderingModel.Navigations = navigableList.NavigableItems.Select(item => ConvertToNavItem(item)).ToList();
            }
            return (IRenderingModelBase)navigationRenderingModel;
        }
        private Models.Navigation ConvertToNavItem(INavigable navigable)
        {

            return new Models.Navigation
            {
                NavigationTitle = new HtmlString(mvcContext.GlassHtml.Editable(navigable, x => x.Title)),
                NavigationUrl = navigable.NavigationUrl != null ? navigable.NavigationUrl.Url : "",
                Navigations = navigable.Children.Any() ? navigable.Children.Select(nav => ConvertToNavItem(nav)).ToList() : null
            };
        }
    }
}