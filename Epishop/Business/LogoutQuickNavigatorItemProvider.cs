using EPiServer.ServiceLocation;
using EPiServer.Web.PageExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer;
using EPiServer.Web.Routing;

namespace Epishop.Business
{
    [ServiceConfiguration(typeof(IQuickNavigatorItemProvider))]
    public class LogoutQuickNavigatorItemProvider : IQuickNavigatorItemProvider
    {
        private readonly IContentLoader contentLoader;
        public int SortOrder
        {
            get
            {
                return 10;
            }
        }

        public LogoutQuickNavigatorItemProvider(IContentLoader contentLoader)
        {
            this.contentLoader = contentLoader;
        }

        public IDictionary<string, QuickNavigatorMenuItem> GetMenuItems(ContentReference currentContent)
        {
            var urlBuilder = new UrlBuilder("/logout");
            if (this.IsPageData(currentContent))
            {
                var urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
                string url = urlResolver.GetUrl(currentContent);

                urlBuilder.QueryCollection.Add("ReturnUrl", url);
            }

            return new Dictionary<string, QuickNavigatorMenuItem> {
                {
                    "customlogout",
                    new QuickNavigatorMenuItem("/shell/cms/menu/logout", urlBuilder.ToString(), null, "true", null)
                }
            };
        }
        private bool IsPageData(ContentReference currentContentLink)
        {
            return this.contentLoader.Get<IContent>(currentContentLink) is PageData;
        }
    }
}