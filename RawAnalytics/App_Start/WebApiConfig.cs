namespace RawAnalytics
{
	using System.Web.Http;

	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API routes
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "RawAnalyticsDefaultRoute",
				routeTemplate: "Insert"
			);
		}
	}
}
