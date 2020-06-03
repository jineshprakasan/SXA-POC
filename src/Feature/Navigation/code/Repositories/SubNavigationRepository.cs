using Aceto.XA.Feature.Navigation.GlassModels;
using Aceto.XA.Feature.Navigation.Models;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Data.Items;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System.Collections.Generic;
using System.Web;

namespace Aceto.XA.Feature.Navigation.Repositories
{
    public class SubNavigationRepository : ModelRepository, ISubNavigationRepository
    {
        private ISitecoreService sitecoreService;
        private readonly IMvcContext mvcContext;
        public SubNavigationRepository(ISitecoreService sitecoreServiceObj, IMvcContext mvcContextObj)
        {
            sitecoreService = sitecoreServiceObj;
            mvcContext = mvcContextObj;
        }
        public override IRenderingModelBase GetModel()
        {
            SubNavigationRenderingModel subNavigationRenderingModel = new SubNavigationRenderingModel();
            this.FillBaseProperties((object)subNavigationRenderingModel);
            subNavigationRenderingModel.SubNavItems = GetSubNavItems();
            subNavigationRenderingModel.CurrentItem = PageContext.Current.DescendsFrom(Templates.SubNav.ID) ? ContentRepository.GetFieldValue("Sub Navigation Title", PageContext.Current) : string.Empty;
            return (IRenderingModelBase)subNavigationRenderingModel;
        }
        private List<SubNavItem> GetSubNavItems()
        {
            List<SubNavItem> subNavItems = new List<SubNavItem>();
            if (PageContext.Current.DescendsFrom(Templates.SubNav.ID))
            {
                Item parent = PageContext.Current.Parent;
                foreach (Item item in parent.GetChildren())
                {
                    if (item.DescendsFrom(Templates.SubNav.ID))
                    {
                        ISubNav subNav = sitecoreService.GetItem<ISubNav>(new GetItemByItemOptions { Item = item });
                        if (subNav != null)
                        {
                            subNavItems.Add(new SubNavItem
                            {
                                Title =new HtmlString( mvcContext.GlassHtml.Editable(subNav, x => x.Title)),
                                Icon = new HtmlString(mvcContext.GlassHtml.Editable(subNav, x => x.Icon)),
                                ActiveIcon = new HtmlString(mvcContext.GlassHtml.Editable(subNav, x => x.ActiveIcon)),
                                Url = subNav.Url
                            });
                        }
                    }
                }
            }
            return subNavItems;
        }

    }
}