using System.Web;
using System.Web.Optimization;
using BundleTransformer.Core.Transformers;

namespace Pazzo_test
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //使用StyleTransformer解決網站或是應用程式進而轉換成對應的相對路徑 
            var styleBundle = new StyleBundle("~/Content/css")
                    .Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/animate.css",
                      "~/Content/CompiledCss/shared/sharedStyle.css",
                      "~/Content/style.css",
                      "~/Content/bootstrap-combobox.css")
                    .Include("~/Content/kendo/2016.2.504/kendo.common.min.css")
                    .Include("~/Content/kendo/2016.2.504/kendo.default.min.css")
                  //  .Include("~/Content/kendo/2016.2.504/kendo.bootstrap.min.css")
                  .Include("~/Content/kendo/2016.2.504/kendo.common-bootstrap.min.css")
                    .Include("~/Content/kendo/kendo.custom.css");

            styleBundle.Transforms.Add(new StyleTransformer());
            bundles.Add(styleBundle);

            bundles.Add(new ScriptBundle("~/bundles/kendoui").Include(
          "~/Scripts/kendo/2016.2.504/kendo.all.min.js",
          "~/Scripts/kendo/2016.2.504/jszip.min.js",
          string.Format("~/Scripts/kendo/2016.2.504/cultures/kendo.culture.{0}.min.js", "zh-TW"),
          string.Format("~/Scripts/kendo/2016.2.504/messages/kendo.messages.{0}.min.js", "zh-TW")));
        }
    }
}
