﻿using System.Web.Optimization;

namespace TasklistWebApp
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
				"~/Scripts/jquery.min.js",
				"~/Scripts/jquery.mask.js"));

			bundles.Add(new ScriptBundle("~/bundles/angular").Include(
				"~/Scripts/angular.min.js",
				"~/Scripts/modules/angular-ui-router.min.js",
				"~/Scripts/modules/ocLazyLoad.min.js"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
				"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
				"~/Scripts/bootstrap.min.js",
				"~/Scripts/respond.min.js"));

			bundles.Add(new ScriptBundle("~/bundles/tasklist").Include(
				  "~/Scripts/controllers/tasklist/home.js"));

		bundles.Add(new StyleBundle("~/Content/css").Include(
				 "~/Content/bootstrap.css",
				 "~/Content/Site.css"));

#if DEBUG
			BundleTable.EnableOptimizations = false;
#else
			BundleTable.EnableOptimizations = true;
#endif

		}
	}
}
