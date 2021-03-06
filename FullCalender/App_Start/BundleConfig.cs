﻿using System.Web;
using System.Web.Optimization;

namespace FullCalender
{
    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Calendar css file
            bundles.Add(new StyleBundle("~/Content/fullcalendarcss").Include(
                     "~/Content/themes/base/all.css",
                     "~/Content/fullcalendar.css"));

            //Calendar Script file
            bundles.Add(new ScriptBundle("~/bundles/fullcalendarjs").Include(
                      "~/Scripts/jquery-ui-{version}.js",
                      "~/Scripts/moment.min.js",
                      "~/Scripts/fullcalendar.min.js",
                      "~/Scripts/lang-all.js"));
        }
    }
}
