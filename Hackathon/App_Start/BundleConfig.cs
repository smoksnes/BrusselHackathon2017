using System.Web;
using System.Web.Optimization;

namespace Hackathon
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/jquery-*",
                "~/Scripts/angular.min.js",
                "~/Scripts/angular-mocks*",
                "~/Scripts/angular-animate*",
                "~/Scripts/angular-aria*",
                "~/Scripts/materialize/materialize.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").IncludeDirectory("~/Scripts/app", "*.js", true));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/materialize/css/materialize*",
                      "~/Content/site.css"));
        }
    }
}
