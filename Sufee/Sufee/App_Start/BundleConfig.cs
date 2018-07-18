using System.Web;
using System.Web.Optimization;

namespace Sufee
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/assets/js/vendor/jquery-2.1.4.min.js",
                        "~/assets/js/plugins.js",
                        "~/assets/js/main.js",
                        "~/assets/js/lib/chart-js/Chart.bundle.js",
                        "~/assets/js/dashboard.js",
                        "~/assets/js/widgets.js",
                        "~/assets/js/lib/vector-map/jquery.vmap.js",
                        "~/assets/js/lib/vector-map/jquery.vmap.min.js",
                        "~/assets/js/lib/vector-map/jquery.vmap.sampledata.js",
                        "~/assets/js/lib/vector-map/country/jquery.vmap.world.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        //"~/Content/bootstrap.css",
                        //"~/Content/site.css",
                        "~/assets/css/normalize.css",
                        "~/assets/css/bootstrap.min.css",
                        "~/assets/css/font-awesome.min.css",
                        "~/assets/css/themify-icons.css",
                        "~/assets/css/flag-icon.min.css",
                        "~/assets/css/cs-skin-elastic.css",
                        "~/assets/css/bootstrap-select.less",
                        "~/assets/scss/style.css",
                        "~/assets/css/lib/vector-map/jqvmap.min.css"));
        }
    }
}
