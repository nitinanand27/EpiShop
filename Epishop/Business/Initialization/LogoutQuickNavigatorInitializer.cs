using System;
using System.Linq;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System.Web.Routing;

namespace Epishop.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class LogoutQuickNavigatorInitializer : IInitializableModule
    {
        private const string RouteName = "LogoutRedirect";
        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized
            RouteTable.Routes.Add(RouteName, new Route("logout", new LogoutRedirectRouteHandler()));
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
            RouteTable.Routes.Remove(RouteTable.Routes[RouteName]);
        }
    }
}