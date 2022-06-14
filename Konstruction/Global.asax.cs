using Konstruction.Filters;
using Konstruction.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Konstruction
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            IFilterProvider[] providers = FilterProviders.Providers.ToArray();
            FilterProviders.Providers.Clear();
            FilterProviders.Providers.Add(new ExcludeFilterProvider(providers));

            ModelBinders.Binders.DefaultBinder = new DevExpress.Web.Mvc.DevExpressEditorsBinder();
            ControllerBuilder.Current.SetControllerFactory(new BaseControllerFactory());

            DevExpress.Web.ASPxWebControl.CallbackError += Application_Error;
        }

        protected void Application_Error(object sender, EventArgs e) 
        {
            Exception exception = System.Web.HttpContext.Current.Server.GetLastError();
            //TODO: Handle Exception
        }
    }
}