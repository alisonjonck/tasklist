using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TasklistWebApp.App_Start;
using TasklistWebApp.Helpers;

namespace TasklistWebApp
{
	public class MvcApplication : HttpApplication
	{
		protected void Application_Start()
		{
			System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("pt-BR");

			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}

		protected void Application_AuthenticateRequest(Object sender, EventArgs e)
		{
			string requestPath = HttpContext.Current.Request.RawUrl;

			if (HttpContext.Current.Request.RequestType == "GET" && AngularRoutesHelper.IsAngularRoute(requestPath))
			{
				HttpContext.Current.Response.Redirect(AngularRoutesHelper.ResolveAngularUri(requestPath));
			}
		}
	}
}
