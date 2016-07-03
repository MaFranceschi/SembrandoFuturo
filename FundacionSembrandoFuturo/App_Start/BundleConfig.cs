using System.Web;
using System.Web.Optimization;

namespace FundacionSembrandoFuturo
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
      
            #region Javascript Files
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/utilities")
                .Include("~/assets/js/jflickfeed.js",
                "~/assets/js/jquery.flexslider.js",
                "~/assets/js/jquery.quicksand.js",
                "~/assets/js/jquery.tweet.js",
                "~/assets/js/jquery.ui.map.min.js",
                "~/assets/js/scripts.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/home")
                .Include("~/assets/bootstrap/js/bootstrap.js",
                "~/assets/bootstrap/js/bootstrap.min.js",
                "~/assets/prettyPhoto/js/jquery.prettyPhoto.js"
                ));
            #endregion

            #region Css Files
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/assets/css/style.css"));

            bundles.Add(new StyleBundle("~/Content/home")
                .Include("~/assets/css/font-awesome.css",
               "~/assets/css/flexslider.css"));

            bundles.Add(new StyleBundle("~/Content/themes")
                .Include("~/assets/bootstrap/css/bootstrap.css",
                "~/assets/bootstrap/css/bootstrap.min.css",
                "~/assets/prettyPhoto/css/prettyPhoto.css"));

            bundles.Add(new StyleBundle("~/Content/google")
                .Include("~/assets/css/fontmap1.css",
                "~/assets/css/fontmap2.css",
                "~/assets/css/googlemap.css"));
            #endregion
        }
    }
}